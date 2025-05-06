using FFTW.NET;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class MainPg : Form
    {
        readonly Fourrier fft = new Fourrier();
        readonly LoginPg log = new LoginPg();
        WaveIn wave;
        WaveFileWriter writer;
        int rec = 0;
        string fileName;
        readonly List<int> oi = new List<int>();

        public MainPg()
        {
            InitializeComponent();
            lbUsername.Visible = false;
            pbUser.Visible = false;
            btRight.Visible = false;
            btLeft.Visible = false;
            pbTabs.Visible = false;
            pbProfile.Visible = false;
            pbConvert.AllowDrop = true;
            pbImgConv.AllowDrop = true;
            btUpload.AllowDrop = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath region = new GraphicsPath();
            region.AddEllipse(0, 0, btGrav.Width, btGrav.Height);
            btGrav.Region = new Region(region);

            region = new GraphicsPath();
            region.AddEllipse(0, 0, btStopRec.Width, btStopRec.Height);
            btStopRec.Region = new Region(region);
        }

        private void ProfileCall()
        {
            ProfilePg profilePg = new ProfilePg(log);
            this.Hide();
            profilePg.ShowDialog();
            this.Show();

            using (MemoryStream ms = new MemoryStream(log.user.Foto))
                pbUser.Image = Image.FromStream(ms);
        }

        private void MouseLeavUpload()
        {
            pbConvert.BackColor = Color.Transparent;
            btUpload.BackColor = Color.Transparent;
            pbImgConv.BackColor = Color.Transparent;
        }

        private void MouseEnterUpload(DragEventArgs e)
        {
            pbConvert.BackColor = Color.White;
            btUpload.BackColor = Color.White;
            pbImgConv.BackColor = Color.White;
            e.Effect = DragDropEffects.Copy;
        }

        private void Logged(RegisterPg rp = null)
        {
            MessageBox.Show("Acesso realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK);

            Point P = new Point();
            btRegister.Visible = false;
            btLogin.Visible = false;

            if(rp != null)
                log.user = rp.user;

            lbUsername.Text = log.user.Nome;
            P.Y = lbUsername.Location.Y;
            P.X = lbUsername.Location.X - lbUsername.Width / 2;
            lbUsername.Location = P;
            lbUsername.Visible = true;
            pbUser.Visible = true;
            btLeft.Visible = true;
            btRight.Visible = true;
            pbTabs.Visible = true;
            pbProfile.Visible = true;

            using (MemoryStream ms = new MemoryStream(log.user.Foto))
                pbUser.Image = Image.FromStream(ms);
        }

        private void DragDropped(DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "WAV File (.wav)|.wav;"
            };
            if (save.ShowDialog() != DialogResult.OK) return;

            if (data != null)
            {
                var fileNames = data as string[];

                if (fileNames.Length > 0)
                {
                    using (Mp3FileReader mp3 = new Mp3FileReader(fileNames[0]))
                    {
                        using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                        {
                            WaveFileWriter.CreateWaveFile(save.FileName, pcm);
                        }
                    }
                }
            }
            MouseLeavUpload();
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
            btStopRec.Visible = false;
            btGrav.Visible = true;
            pbRec.Visible = false;
        }

        private void Rec_Tick(object sender, EventArgs e)
        {
            rec++;
            if (rec % 2 != 0)
            {
                pbRec.Image = SlahTune.Properties.Resources.RecONImg;
            }
            else
            {
                pbRec.Image = SlahTune.Properties.Resources.RecOffImg;
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            log.ShowDialog();

            if (log.DialogResult == DialogResult.OK)
            {
                Logged();
            }
            log.Hide();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            RegisterPg rp = new RegisterPg();

            rp.ShowDialog();

            if(rp.DialogResult == DialogResult.OK)
            {
                Logged(rp);
            }
        }

        private void PbUser_Click(object sender, EventArgs e)
        {
            ProfileCall();
        }

        private void BtGrav_Click(object sender, EventArgs e)
        {
            btUpload.Enabled = false;
            btLeft.Enabled = false;
            btRight.Enabled = false;
            btLogin.Enabled = false;
            btRegister.Enabled = false;
            pbConvert.AllowDrop = false;
            pbImgConv.AllowDrop = false;
            btUpload.AllowDrop = false;

            SelMicPg selMic = new SelMicPg();
            selMic.ShowDialog();

            if(selMic.sel)
            {
                Timer rec = new Timer
                {
                    Interval = 1000
                };
                rec.Tick += Rec_Tick;
                rec.Start();

                fileName = selMic.OutputFileName;
                int deviceId = selMic.deviceID;

                btGrav.Visible = false;
                btStopRec.Visible = true;
                pbRec.Visible = true;

                wave = new WaveIn
                {
                    WaveFormat = new WaveFormat(44100, 1),
                    DeviceNumber = deviceId
                };
                wave.DataAvailable += Wave_DataAvailable;
                wave.RecordingStopped += Wave_RecordingStopped;
                writer = new WaveFileWriter(fileName, wave.WaveFormat);
                wave.StartRecording();
            }
        }

        private void BtStopRec_Click(object sender, EventArgs e)
        {
            wave.StopRecording();

            if (fileName == null)
                return;

            var processStartInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(fileName), UseShellExecute = true
            };

            Process.Start(processStartInfo);

            btUpload.Enabled = true;
            btLeft.Enabled = true;
            btRight.Enabled = true;
            btLogin.Enabled = true;
            btRegister.Enabled = true;
            pbConvert.AllowDrop = true;
            pbImgConv.AllowDrop = true;
            btUpload.AllowDrop = true;
        }

        private void BtGrav_MouseLeave(object sender, EventArgs e)
        {
            btGrav.BackColor = Color.Transparent;
        }

        private void BtGrav_MouseEnter(object sender, EventArgs e)
        {
            btGrav.BackColor = Color.Gray;
        }

        private void BtRight_MouseEnter(object sender, EventArgs e)
        {
            btRight.Image = SlahTune.Properties.Resources.BtGoRightSel;
        }

        private void BtRight_MouseLeave(object sender, EventArgs e)
        {
            btRight.Image = SlahTune.Properties.Resources.BtGoRight;
        }

        private void BtLeft_MouseEnter(object sender, EventArgs e)
        {
            btLeft.Image = SlahTune.Properties.Resources.BtGoLeftSel;
        }

        private void BtLeft_MouseLeave(object sender, EventArgs e)
        {
            btLeft.Image = SlahTune.Properties.Resources.BtGoLeft;
        }

        private void BtRight_Click(object sender, EventArgs e)
        {
            TabsPg tabsPg = new TabsPg(log);
            this.Hide();
            tabsPg.ShowDialog();
            this.Show();
        }

        private void BtLeft_Click(object sender, EventArgs e)
        {
            ProfileCall();
        }

        private void BtUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog oi = new OpenFileDialog();

            if (oi.ShowDialog() == DialogResult.OK)
            {
                fileName = oi.FileName;
                Complex[] oie = fft.AudioToComplex(fileName);
                IPinnedArray<Complex> oies = fft.ComputeFFT(oie);

                double[] ooi = new double[1024];

                Random r = new Random();

                for (int i = 0; i < oies.Length; i++)
                {
                    ooi[i] = oies[i].Real;
                }

                int inteiro = 0;

                for (int i = 0; i < 1024; i++)
                {
                    string ola = ooi[i].ToString();
                    if (ola.Length < 3 || ola[0] == '0' && ola[1] == ',' && ola[2] == '0' || ola[0] == '-' && ola[1] == '0' && ola[2] == ',' && ola[3] == '0')
                    {
                        ooi[i] = 0;
                        inteiro++;
                    }
                }

                double[] fftn = new double[1024 - inteiro];

                int j = 0;

                for (int i = 0; i < ooi.Length; i++)
                {
                    if (ooi[i] != 0)
                    {
                        fftn[j] = ooi[i];
                        j++;
                    }
                }

                for (int i = 0; i < fftn.Length; i++)
                    for (int i2 = 0; i2 < fftn[i].ToString().Length; i2++)
                        if (fftn[i].ToString()[i2] == 'E')
                        {
                            char[] semE = new char[fftn[i].ToString().Length - 4];
                            for (int i3 = 0; i3 < fftn[i].ToString().Length; i3++)
                            {
                                if (fftn[i].ToString()[i3] != 'E')
                                    semE[i3] = fftn[i].ToString()[i3];
                                else
                                    i3 = 100000;
                            }
                            string semEs = new string(semE);
                            fftn[i] = double.Parse(semEs);
                        }

                using(StreamWriter st = new StreamWriter("c:\\temp\\teste.txt"))
                {
                    for (int i = 0; i < fftn.Length; i++)
                        st.WriteLine("" + fftn[i]);
                    st.Close();
                }                    

                if (oi.ShowDialog() == DialogResult.OK)
                {
                    fileName = oi.FileName;
                    Complex[] oie2 = fft.AudioToComplex(fileName);
                    IPinnedArray<Complex> oies2 = fft.ComputeFFT(oie2);

                    double[] ooi2 = new double[1024];

                    for (int i = 0; i < oies2.Length; i++)
                    {
                        ooi2[i] = oies2[i].Real;
                    }

                    inteiro = 0;

                    for (int i = 0; i < 1024; i++)
                    {
                        string ola = ooi2[i].ToString();
                        if (ola.Length < 3 || ola[0] == '0' && ola[1] == ',' && ola[2] == '0' || ola[0] == '-' && ola[1] == '0' && ola[2] == ',' && ola[3] == '0')
                        {
                            ooi2[i] = 0;
                            inteiro++;
                        }
                    }

                    double[] fftn2 = new double[1024 - inteiro];

                    int j2= 0;

                    for (int i = 0; i < ooi2.Length; i++)
                    {
                        if (ooi2[i] != 0)
                        {
                            fftn2[j2] = ooi2[i];
                            j2++;
                        }
                    }

                    for (int i = 0; i < fftn2.Length; i++)
                        for (int i2 = 0; i2 < fftn2[i].ToString().Length; i2++)
                            if (fftn2[i].ToString()[i2] == 'E')
                            {
                                char[] semE = new char[fftn2[i].ToString().Length - 4];
                                for (int i3 = 0; i3 < fftn2[i].ToString().Length; i3++)
                                {
                                    if (fftn2[i].ToString()[i3] != 'E')
                                        semE[i3] = fftn2[i].ToString()[i3];
                                    else
                                        i3 = 100000;
                                }
                                string semEs = new string(semE);
                                fftn2[i] = double.Parse(semEs);
                            }

                    int[] contador = new int[fftn.Length];

                    for (int i = 0; i < fftn.Length; i++)
                        for (int i2 = 0; i2 < fftn2.Length; i2++)
                            if (fftn[i] > fftn2[i2] - 0.2 && fftn[i] < fftn2[i2] + 0.2)
                                contador[i]++;

                    int porc = 0;
                    for (int i = 0; i < contador.Length; i++)
                        if(contador[i] == 0)
                            porc++;

                    porc = 100 - ((porc * 100) / contador.Length);

                    MessageBox.Show("Porcentagem de semelhança: " + porc + "%");

                }
            }
        }
        private void BtUpload_DragEnter(object sender, DragEventArgs e)
        {
            MouseEnterUpload(e);
        }

        private void BtUpload_DragLeave(object sender, EventArgs e)
        {
            MouseLeavUpload();
        }
        
        private void BtUpload_DragDrop(object sender, DragEventArgs e)
        {
            DragDropped(e);
        }

        private void PbConvert_DragEnter(object sender, DragEventArgs e)
        {
            MouseEnterUpload(e);
        }

        private void PbConvert_DragLeave(object sender, EventArgs e)
        {
            MouseLeavUpload();
        }

        private void PbConvert_DragDrop(object sender, DragEventArgs e)
        {
            DragDropped(e);
        }

        private void PbImgConv_DragEnter(object sender, DragEventArgs e)
        {
            MouseEnterUpload(e);
        }

        private void PbImgConv_DragLeave(object sender, EventArgs e)
        {
            MouseLeavUpload();
        }

        private void PbImgConv_DragDrop(object sender, DragEventArgs e)
        {
            DragDropped(e);
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 2)
            {
                oi.Add(int.Parse(textBox1.Text));
                textBox1.Clear();
            }
            else
            {
                string nome = textBox1.Text;
                Tabla tab = new Tabla(oi);

                Musica msc = new Musica();
                msc.Nome = nome;

                using (SlahTuneEntities st = new SlahTuneEntities())
                {
                    st.Musica.Add(msc);
                    st.SaveChanges();
                }

                Tablatura tabd = new Tablatura();

                tabd.IDMusica = msc.ID;

                if (log.user != null)
                    tabd.IDUsuario = log.user.ID;

                using (SlahTuneEntities st = new SlahTuneEntities())
                {
                    st.Tablatura.Add(tabd);
                    st.SaveChanges();
                }

                nome = tabd.ID.ToString();

                tabd.Identificador = "c:\\temp\\" + nome + ".txt";

                StreamWriter text = new StreamWriter(tabd.Identificador);
                for (int i = 0; i < tab.tabString.Length; i++)
                    text.WriteLine("" + tab.tabString[i]);
                text.Close();

                using (SlahTuneEntities bd = new SlahTuneEntities())
                {
                    bd.Tablatura.Attach(tabd);

                    bd.Entry(tabd).Property(u => u.Identificador).IsModified = true;

                    bd.SaveChanges();
                }
            }
        }
    }
}