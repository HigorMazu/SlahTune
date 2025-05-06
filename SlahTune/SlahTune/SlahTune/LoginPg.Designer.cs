namespace SlahTune
{
    partial class LoginPg
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloCadastro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.BotLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barraSuperior1 = new SlahTune.BarraSuperior();
            this.SuspendLayout();
            // 
            // TituloCadastro
            // 
            this.TituloCadastro.AutoSize = true;
            this.TituloCadastro.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold);
            this.TituloCadastro.ForeColor = System.Drawing.Color.White;
            this.TituloCadastro.Location = new System.Drawing.Point(184, 27);
            this.TituloCadastro.Name = "TituloCadastro";
            this.TituloCadastro.Size = new System.Drawing.Size(195, 52);
            this.TituloCadastro.TabIndex = 0;
            this.TituloCadastro.Text = "SlahTune";
            this.TituloCadastro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbUser.Location = new System.Drawing.Point(113, 82);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(389, 26);
            this.tbUser.TabIndex = 3;
            this.tbUser.TextChanged += new System.EventHandler(this.TbUsuario_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbSenha.Location = new System.Drawing.Point(113, 120);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.Size = new System.Drawing.Size(389, 26);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.TextChanged += new System.EventHandler(this.TbSenha_TextChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(191, 156);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(124, 24);
            this.cbMostrarSenha.TabIndex = 6;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.CbMostrarSenha_CheckedChanged);
            // 
            // BotLogin
            // 
            this.BotLogin.BackColor = System.Drawing.SystemColors.Window;
            this.BotLogin.FlatAppearance.BorderSize = 0;
            this.BotLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotLogin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.BotLogin.Location = new System.Drawing.Point(427, 157);
            this.BotLogin.Name = "BotLogin";
            this.BotLogin.Size = new System.Drawing.Size(75, 23);
            this.BotLogin.TabIndex = 8;
            this.BotLogin.Text = "Login";
            this.BotLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotLogin.UseVisualStyleBackColor = false;
            this.BotLogin.Visible = false;
            this.BotLogin.Click += new System.EventHandler(this.BotLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Senha";
            // 
            // barraSuperior1
            // 
            this.barraSuperior1.BarText = " Login";
            this.barraSuperior1.CloseApplicationOnCloseForm = false;
            this.barraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior1.Name = "barraSuperior1";
            this.barraSuperior1.ShowMaximizeButton = false;
            this.barraSuperior1.ShowMinimizeButton = true;
            this.barraSuperior1.Size = new System.Drawing.Size(514, 27);
            this.barraSuperior1.TabIndex = 11;
            // 
            // LoginPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(514, 192);
            this.Controls.Add(this.barraSuperior1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotLogin);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TituloCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Button BotLogin;
        public System.Windows.Forms.Label label1;
        private BarraSuperior barraSuperior1;
    }
}