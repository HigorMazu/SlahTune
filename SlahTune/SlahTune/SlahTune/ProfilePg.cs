using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class ProfilePg : Form
    {
        readonly LoginPg log;
        public ProfilePg(LoginPg Lg)
        {
            InitializeComponent();
            log = Lg;            
        }

        private void ProfilePg_Load(object sender, EventArgs e)
        {
            lbUsername.Text = log.user.Nome;

            Point p = pbEditUsername.Location;
            p.X = lbUsername.Location.X + lbUsername.Width + 10;
            pbEditUsername.Location = p;

            lbEmail.Text = log.user.Email;
            p = lbEmail.Location;
            p.X = lbEmail.Location.X + lbEmail.Width + 10;
            pbEditEmail.Location = p;

            pb1.Image = SlahTune.Properties.Resources.Default;
            pb2.Image = SlahTune.Properties.Resources.Verdim;
            pb3.Image = SlahTune.Properties.Resources.Vermei;

            using (MemoryStream ms = new MemoryStream(log.user.Foto))
                pbProfile.Image = Image.FromStream(ms);
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            log.MudarFoto(pb1.Image);
            pbProfile.Image = pb1.Image;
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            log.MudarFoto(pb2.Image);
            pbProfile.Image = pb2.Image;
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            log.MudarFoto(pb3.Image);
            pbProfile.Image = pb3.Image;
        }

        private void NovaFoto()
        {
            string origemCompleto = "";
            string foto;
            string pastaDestino = "";
            string destinoCompleto = "";

            OpenFileDialog imagePickerDialog = new OpenFileDialog();

            if (imagePickerDialog.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = imagePickerDialog.FileName;
                foto = imagePickerDialog.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(origemCompleto, destinoCompleto, true);

            if (File.Exists(destinoCompleto))
            {
                pbProfile.Image = Image.FromFile(destinoCompleto);
                log.MudarFoto(pbProfile.Image);
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }

        private void PbEditProfilePic_Click(object sender, EventArgs e)
        {
            NovaFoto();
        }

        private void BtRight_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbProfile_Click(object sender, EventArgs e)
        {
            NovaFoto();
        }

        private void PbUser_Click(object sender, EventArgs e)
        {
            NovaFoto();
        }
    }
}