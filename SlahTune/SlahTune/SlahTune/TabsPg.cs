using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class TabsPg : Form
    {
        LoginPg log = new LoginPg();
        public TabsPg(LoginPg Log)
        {
            InitializeComponent();
            log = Log;        
        }

        private void TabsPg_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(log.user.Foto))
                pbUser.Image = Image.FromStream(ms);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
