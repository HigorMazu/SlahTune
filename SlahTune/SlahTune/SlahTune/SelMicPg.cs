using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class SelMicPg : Form
    {
        public string OutputFileName;
        public int deviceID;
        public bool sel;
        public SelMicPg()
        {
            InitializeComponent();
            CarregarDispositivos();
        }

        private void CarregarDispositivos()
        {
            for (int IdMic = 0; IdMic < WaveIn.DeviceCount; IdMic++)
            {
                var InfoDispositivo = WaveIn.GetCapabilities(IdMic);
                CbMic.Items.Add(InfoDispositivo.ProductName);
            }
            for (int IdMic = 0; IdMic < WaveOut.DeviceCount; IdMic++)
            {
                var InfoDispositivo = WaveOut.GetCapabilities(IdMic);
                CbMic.Items.Add(InfoDispositivo.ProductName);
            }
        }

        private void BotGrav_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files | *.wav";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            OutputFileName = dialog.FileName;

            deviceID = CbMic.SelectedIndex;

            sel = true;

            this.Hide();
        }
        private void BotX_Click(object sender, EventArgs e)
        {
            Close();
            sel = false;
        }

        private void BotMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}