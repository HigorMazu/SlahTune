using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class LoginPg : Form
    {
        public Usuario user;

        public LoginPg()
        {
            InitializeComponent();
        }

        private void CbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
                tbSenha.PasswordChar = '\0';
            if (!cbMostrarSenha.Checked)
                tbSenha.PasswordChar = '●';
        }

        private void TbUsuario_TextChanged(object sender, EventArgs e)
        {
            BotLogin.Visible = tbUser.Text.Length > 0 && tbSenha.Text.Length > 0;
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {
            BotLogin.Visible = tbUser.Text.Length > 0 && tbSenha.Text.Length > 0;
        }

        private void BotLogin_Click(object sender, EventArgs e)
        {
            var passbytes = tbSenha.Text.Trim().Select(c => (byte)c).ToArray();
            MD5 md5 = MD5.Create();
            byte[] criptopass = md5.ComputeHash(passbytes);
            string cripted = String.Concat(criptopass.Select(b => (char)b).ToArray());

            using(SlahTuneEntities bd = new SlahTuneEntities())
            {
                var user = bd.Usuario.FirstOrDefault(u => u.Nome == tbUser.Text.Trim() && u.Senha == cripted);

                if (user == null)
                {
                    MessageBox.Show("Credenciais inválidas!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.user = user;
                }
            }
        }

        public void MudarFoto(Image novaFoto)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                novaFoto.Save(ms, ImageFormat.Png);
                user.Foto = ms.GetBuffer();
            }

            using (SlahTuneEntities bd = new SlahTuneEntities())
            {
                bd.Usuario.Attach(user);

                bd.Entry(user).Property(u => u.Foto).IsModified = true;

                bd.SaveChanges();
            }
        }
    }
}