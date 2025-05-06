using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class BarraSuperior : UserControl
    {
        [Browsable(true)]
        public bool CloseApplicationOnCloseForm { get; set; } = false;

        [Browsable(true)]
        public bool ShowMaximizeButton
        {
            get => BotMaxJan.Visible;
            set => BotMaxJan.Visible = value;
        }

        [Browsable(true)]
        public bool ShowMinimizeButton
        {
            get => BotMini.Visible;
            set => BotMini.Visible = value;
        }

        [Browsable(true)]
        public string BarText
        {
            get
            {
                return Topo.Text;
            }
            set
            {
                Topo.Text = value;
            }
        }


        private Point? p = null;

        public BarraSuperior()
        {
            InitializeComponent();
        }

        public Form Form
        {
            get
            {
                var parent = this.Parent;
                while (!(parent is Form))
                    parent = parent.Parent;
                return parent as Form;
            }
        }

        private void BotFechar_Click(object sender, EventArgs e)
        {
            if (CloseApplicationOnCloseForm)
                Application.Exit();
            else Form.Close();
        }

        private void BotMaxJan_Click(object sender, EventArgs e)
        {
            Form.WindowState = Form.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void BotMini_Click(object sender, EventArgs e)
        {
            Form.WindowState = FormWindowState.Minimized;
        }

        private void Topo_MouseUp(object sender, MouseEventArgs e)
            => p = null;

        private void Topo_MouseMove(object sender, MouseEventArgs e)
        {
            if (p == null)
                return;
            var form = Form;
            int dx = e.X - p.Value.X;
            int dy = e.Y - p.Value.Y;
            form.Location = new Point(form.Location.X + dx, form.Location.Y + dy);
        }

        private void Topo_MouseDown(object sender, MouseEventArgs e)
            => p = e.Location;
    }
}