namespace SlahTune
{
    partial class RegisterPg
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.BtCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.barraSuperior1 = new SlahTune.BarraSuperior();
            this.tbConfSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloCadastro
            // 
            this.TituloCadastro.AutoSize = true;
            this.TituloCadastro.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold);
            this.TituloCadastro.ForeColor = System.Drawing.Color.White;
            this.TituloCadastro.Location = new System.Drawing.Point(182, 28);
            this.TituloCadastro.Name = "TituloCadastro";
            this.TituloCadastro.Size = new System.Drawing.Size(195, 52);
            this.TituloCadastro.TabIndex = 0;
            this.TituloCadastro.Text = "SlahTune";
            this.TituloCadastro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome de Usuário";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbUsername.Location = new System.Drawing.Point(191, 115);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(309, 26);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextChanged += new System.EventHandler(this.TbUsuario_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbSenha.Location = new System.Drawing.Point(191, 150);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.Size = new System.Drawing.Size(309, 26);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.TextChanged += new System.EventHandler(this.TbSenha_TextChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(191, 220);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(124, 24);
            this.cbMostrarSenha.TabIndex = 5;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.CbMostrarSenha_CheckedChanged);
            // 
            // BtCadastro
            // 
            this.BtCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.BtCadastro.FlatAppearance.BorderSize = 0;
            this.BtCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadastro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.BtCadastro.Location = new System.Drawing.Point(425, 220);
            this.BtCadastro.Name = "BtCadastro";
            this.BtCadastro.Size = new System.Drawing.Size(75, 23);
            this.BtCadastro.TabIndex = 6;
            this.BtCadastro.Text = "Cadastrar";
            this.BtCadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtCadastro.UseVisualStyleBackColor = false;
            this.BtCadastro.Visible = false;
            this.BtCadastro.Click += new System.EventHandler(this.BtCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Senha";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbEmail.Location = new System.Drawing.Point(191, 80);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(309, 26);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // barraSuperior1
            // 
            this.barraSuperior1.BarText = " Cadastrar";
            this.barraSuperior1.CloseApplicationOnCloseForm = false;
            this.barraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior1.Name = "barraSuperior1";
            this.barraSuperior1.ShowMaximizeButton = false;
            this.barraSuperior1.ShowMinimizeButton = true;
            this.barraSuperior1.Size = new System.Drawing.Size(513, 28);
            this.barraSuperior1.TabIndex = 7;
            // 
            // tbConfSenha
            // 
            this.tbConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbConfSenha.Location = new System.Drawing.Point(191, 185);
            this.tbConfSenha.Name = "tbConfSenha";
            this.tbConfSenha.PasswordChar = '●';
            this.tbConfSenha.Size = new System.Drawing.Size(309, 26);
            this.tbConfSenha.TabIndex = 4;
            this.tbConfSenha.TextChanged += new System.EventHandler(this.TbConfSenha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirmar Senha";
            // 
            // RegisterPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(513, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfSenha);
            this.Controls.Add(this.barraSuperior1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCadastro);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TituloCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Button BtCadastro;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private BarraSuperior barraSuperior1;
        private System.Windows.Forms.TextBox tbConfSenha;
        public System.Windows.Forms.Label label4;
    }
}