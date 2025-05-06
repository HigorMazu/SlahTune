namespace SlahTune
{
    partial class TabsPg
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
            this.Titulo = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbDown = new System.Windows.Forms.Label();
            this.pbTabs = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.pbLeftImg = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.barraSuperior1 = new SlahTune.BarraSuperior();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(641, 72);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(234, 63);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "SlahTune";
            // 
            // LbUsername
            // 
            this.LbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LbUsername.Location = new System.Drawing.Point(1051, 88);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(0, 29);
            this.LbUsername.TabIndex = 13;
            // 
            // LbDown
            // 
            this.LbDown.BackColor = System.Drawing.Color.Black;
            this.LbDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbDown.Location = new System.Drawing.Point(0, 795);
            this.LbDown.Name = "LbDown";
            this.LbDown.Size = new System.Drawing.Size(1467, 36);
            this.LbDown.TabIndex = 18;
            // 
            // pbTabs
            // 
            this.pbTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTabs.BackColor = System.Drawing.Color.Transparent;
            this.pbTabs.Image = global::SlahTune.Properties.Resources.TabsImg;
            this.pbTabs.Location = new System.Drawing.Point(1273, 58);
            this.pbTabs.Name = "pbTabs";
            this.pbTabs.Size = new System.Drawing.Size(100, 100);
            this.pbTabs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTabs.TabIndex = 24;
            this.pbTabs.TabStop = false;
            // 
            // btLeft
            // 
            this.btLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLeft.FlatAppearance.BorderSize = 0;
            this.btLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLeft.Image = global::SlahTune.Properties.Resources.BtGoLeft;
            this.btLeft.Location = new System.Drawing.Point(408, 247);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(136, 309);
            this.btLeft.TabIndex = 23;
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // pbLeftImg
            // 
            this.pbLeftImg.Image = global::SlahTune.Properties.Resources.LeftFade;
            this.pbLeftImg.Location = new System.Drawing.Point(0, 29);
            this.pbLeftImg.Name = "pbLeftImg";
            this.pbLeftImg.Size = new System.Drawing.Size(550, 1100);
            this.pbLeftImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeftImg.TabIndex = 16;
            this.pbLeftImg.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.Image = global::SlahTune.Properties.Resources.Default;
            this.pbUser.Location = new System.Drawing.Point(958, 58);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(90, 90);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 14;
            this.pbUser.TabStop = false;
            // 
            // barraSuperior1
            // 
            this.barraSuperior1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.barraSuperior1.BarText = " SlahTune™";
            this.barraSuperior1.CloseApplicationOnCloseForm = false;
            this.barraSuperior1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior1.Margin = new System.Windows.Forms.Padding(6);
            this.barraSuperior1.Name = "barraSuperior1";
            this.barraSuperior1.ShowMaximizeButton = true;
            this.barraSuperior1.ShowMinimizeButton = true;
            this.barraSuperior1.Size = new System.Drawing.Size(1467, 29);
            this.barraSuperior1.TabIndex = 12;
            // 
            // TabsPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.pbTabs);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.LbDown);
            this.Controls.Add(this.pbLeftImg);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.barraSuperior1);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TabsPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qa    ";
            this.Load += new System.EventHandler(this.TabsPg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo;
        private BarraSuperior barraSuperior1;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLeftImg;
        private System.Windows.Forms.Label LbDown;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.PictureBox pbTabs;
    }
}