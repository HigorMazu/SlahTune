using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SlahTune
{
    public partial class RegisterPg : Form
    {

        readonly SlahTuneEntities bd = new SlahTuneEntities();
        public Usuario user = new Usuario();
        public RegisterPg()
        {
            InitializeComponent();
        }

        public bool EmailValido(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                tbSenha.PasswordChar = '\0';
                tbConfSenha.PasswordChar = '\0';
            }
                
            if (!cbMostrarSenha.Checked)
            {
                tbSenha.PasswordChar = '●';
                tbConfSenha.PasswordChar = '●';
            }
        }

        private void TbUsuario_TextChanged(object sender, EventArgs e)
        {
            BtCadastro.Visible = tbUsername.Text.Length > 0 && tbSenha.Text.Length > 0 && tbEmail.Text.Length > 0 && tbConfSenha.Text.Length > 0;
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            BtCadastro.Visible = tbUsername.Text.Length > 0 && tbSenha.Text.Length > 0 && tbEmail.Text.Length > 0 && tbConfSenha.Text.Length > 0;
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {
            BtCadastro.Visible = tbUsername.Text.Length > 0 && tbSenha.Text.Length > 0 && tbEmail.Text.Length > 0 && tbConfSenha.Text.Length > 0;
        }

        private void TbConfSenha_TextChanged(object sender, EventArgs e)
        {
            BtCadastro.Visible = tbUsername.Text.Length > 0 && tbSenha.Text.Length > 0 && tbEmail.Text.Length > 0 && tbConfSenha.Text.Length > 0;
        }

        private void ClearAll()
        {
            tbEmail.Clear();
            tbUsername.Clear();
            tbSenha.Clear();
            tbConfSenha.Clear();
        }

        private void BtCadastro_Click(object sender, EventArgs e)
        {
            if (!EmailValido(tbEmail.Text.Trim()))
            {
                MessageBox.Show("O Email é inválido!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            var email = bd.Usuario.FirstOrDefault(u => u.Email == tbEmail.Text.Trim());
            if (email != null)
            {
                MessageBox.Show("O Email já foi cadastrado!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            var nome = bd.Usuario.FirstOrDefault(u => u.Nome == tbUsername.Text.Trim());
            if(nome != null)
            {
                MessageBox.Show("Esse nome de usuário já está sendo utilizado!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            if (tbUsername.Text.Trim().Length < 3)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 3 caracteres!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            if (tbUsername.Text.Trim().Length > 30)
            {
                MessageBox.Show("O nome de usuário deve ter no máximo 30 caracteres!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            if (tbSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            if(tbSenha.Text.Trim().Count(c => c >= 'A' && c <= 'Z') > 0 && tbSenha.Text.Count(c => c >= 'a' && c <= 'z') > 0)
            {
                MessageBox.Show("A senha deve conter letras maiúsculas e minúsculas!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            if(tbSenha.Text.Trim() != tbConfSenha.Text.Trim())
            {
                MessageBox.Show("As senhas não correspondem!", "Tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            user.Nome = tbUsername.Text.Trim();
            user.Email = tbEmail.Text.Trim();
            var passbytes = tbSenha.Text.Trim().Select(c => (byte)c).ToArray();
            MD5 md5 = MD5.Create();
            byte[] criptopass = md5.ComputeHash(passbytes);
            user.Senha = String.Concat(criptopass.Select(b => (char)b).ToArray());
            using (MemoryStream ms = new MemoryStream())
            {
                SlahTune.Properties.Resources.Default.Save(ms, ImageFormat.Png);
                user.Foto = ms.GetBuffer();
            }

            bd.Usuario.Add(user);
            bd.SaveChanges();

            this.DialogResult = DialogResult.OK;
        }
    }
}