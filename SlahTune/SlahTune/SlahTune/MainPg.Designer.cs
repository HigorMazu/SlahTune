namespace SlahTune
{
    partial class MainPg
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.LbDown = new System.Windows.Forms.Label();
            this.btStopRec = new System.Windows.Forms.Button();
            this.pbRec = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbTabs = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.pbImgConv = new System.Windows.Forms.PictureBox();
            this.pbConvert = new System.Windows.Forms.PictureBox();
            this.pbRightImg = new System.Windows.Forms.PictureBox();
            this.pbLeftImg = new System.Windows.Forms.PictureBox();
            this.btGrav = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.barraSuperior1 = new SlahTune.BarraSuperior();
            this.btEnter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(614, 182);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 63);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "SlahTune";
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLogin.Location = new System.Drawing.Point(671, 60);
            this.btLogin.MaximumSize = new System.Drawing.Size(128, 42);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(128, 42);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Fazer Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // btRegister
            // 
            this.btRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRegister.Location = new System.Drawing.Point(671, 108);
            this.btRegister.MaximumSize = new System.Drawing.Size(128, 42);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(128, 42);
            this.btRegister.TabIndex = 9;
            this.btRegister.Text = "Cadastrar";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbUsername.Location = new System.Drawing.Point(733, 153);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 29);
            this.lbUsername.TabIndex = 13;
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
            // btStopRec
            // 
            this.btStopRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btStopRec.BackColor = System.Drawing.Color.Transparent;
            this.btStopRec.FlatAppearance.BorderSize = 0;
            this.btStopRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStopRec.Image = global::SlahTune.Properties.Resources.BtStopRec;
            this.btStopRec.Location = new System.Drawing.Point(671, 400);
            this.btStopRec.Name = "btStopRec";
            this.btStopRec.Size = new System.Drawing.Size(128, 128);
            this.btStopRec.TabIndex = 27;
            this.btStopRec.UseVisualStyleBackColor = false;
            this.btStopRec.Visible = false;
            this.btStopRec.Click += new System.EventHandler(this.BtStopRec_Click);
            // 
            // pbRec
            // 
            this.pbRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbRec.Image = global::SlahTune.Properties.Resources.RecONImg;
            this.pbRec.Location = new System.Drawing.Point(699, 357);
            this.pbRec.Name = "pbRec";
            this.pbRec.Size = new System.Drawing.Size(69, 28);
            this.pbRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRec.TabIndex = 26;
            this.pbRec.TabStop = false;
            this.pbRec.Visible = false;
            // 
            // pbProfile
            // 
            this.pbProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbProfile.BackColor = System.Drawing.Color.Black;
            this.pbProfile.Image = global::SlahTune.Properties.Resources.ProfileImg;
            this.pbProfile.Location = new System.Drawing.Point(320, 357);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(100, 100);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 25;
            this.pbProfile.TabStop = false;
            // 
            // pbTabs
            // 
            this.pbTabs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbTabs.BackColor = System.Drawing.Color.Black;
            this.pbTabs.Image = global::SlahTune.Properties.Resources.TabsImg;
            this.pbTabs.Location = new System.Drawing.Point(1049, 357);
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
            this.btLeft.Click += new System.EventHandler(this.BtLeft_Click);
            this.btLeft.MouseEnter += new System.EventHandler(this.BtLeft_MouseEnter);
            this.btLeft.MouseLeave += new System.EventHandler(this.BtLeft_MouseLeave);
            // 
            // btRight
            // 
            this.btRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRight.FlatAppearance.BorderSize = 0;
            this.btRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRight.Image = global::SlahTune.Properties.Resources.BtGoRight;
            this.btRight.Location = new System.Drawing.Point(923, 247);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(136, 309);
            this.btRight.TabIndex = 22;
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.BtRight_Click);
            this.btRight.MouseEnter += new System.EventHandler(this.BtRight_MouseEnter);
            this.btRight.MouseLeave += new System.EventHandler(this.BtRight_MouseLeave);
            // 
            // pbImgConv
            // 
            this.pbImgConv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbImgConv.BackColor = System.Drawing.Color.DimGray;
            this.pbImgConv.Image = global::SlahTune.Properties.Resources.ConvertImg;
            this.pbImgConv.Location = new System.Drawing.Point(699, 627);
            this.pbImgConv.Name = "pbImgConv";
            this.pbImgConv.Size = new System.Drawing.Size(69, 70);
            this.pbImgConv.TabIndex = 21;
            this.pbImgConv.TabStop = false;
            this.pbImgConv.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbImgConv_DragDrop);
            this.pbImgConv.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbImgConv_DragEnter);
            this.pbImgConv.DragLeave += new System.EventHandler(this.PbImgConv_DragLeave);
            // 
            // pbConvert
            // 
            this.pbConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbConvert.BackColor = System.Drawing.Color.DimGray;
            this.pbConvert.Image = global::SlahTune.Properties.Resources.DragDropImg;
            this.pbConvert.Location = new System.Drawing.Point(556, 598);
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Size = new System.Drawing.Size(355, 194);
            this.pbConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConvert.TabIndex = 19;
            this.pbConvert.TabStop = false;
            this.pbConvert.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbConvert_DragDrop);
            this.pbConvert.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbConvert_DragEnter);
            this.pbConvert.DragLeave += new System.EventHandler(this.PbConvert_DragLeave);
            // 
            // pbRightImg
            // 
            this.pbRightImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRightImg.Image = global::SlahTune.Properties.Resources.BackLeftRight;
            this.pbRightImg.Location = new System.Drawing.Point(917, 29);
            this.pbRightImg.Name = "pbRightImg";
            this.pbRightImg.Size = new System.Drawing.Size(550, 1100);
            this.pbRightImg.TabIndex = 17;
            this.pbRightImg.TabStop = false;
            // 
            // pbLeftImg
            // 
            this.pbLeftImg.Image = global::SlahTune.Properties.Resources.BackRightLeft;
            this.pbLeftImg.Location = new System.Drawing.Point(0, 29);
            this.pbLeftImg.Name = "pbLeftImg";
            this.pbLeftImg.Size = new System.Drawing.Size(550, 1100);
            this.pbLeftImg.TabIndex = 16;
            this.pbLeftImg.TabStop = false;
            // 
            // btGrav
            // 
            this.btGrav.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btGrav.BackColor = System.Drawing.Color.Transparent;
            this.btGrav.FlatAppearance.BorderSize = 0;
            this.btGrav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGrav.Image = global::SlahTune.Properties.Resources.BtPlay;
            this.btGrav.Location = new System.Drawing.Point(639, 330);
            this.btGrav.Name = "btGrav";
            this.btGrav.Size = new System.Drawing.Size(197, 176);
            this.btGrav.TabIndex = 15;
            this.btGrav.UseVisualStyleBackColor = false;
            this.btGrav.Click += new System.EventHandler(this.BtGrav_Click);
            this.btGrav.MouseEnter += new System.EventHandler(this.BtGrav_MouseEnter);
            this.btGrav.MouseLeave += new System.EventHandler(this.BtGrav_MouseLeave);
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.Image = global::SlahTune.Properties.Resources.Default;
            this.pbUser.Location = new System.Drawing.Point(690, 60);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(90, 90);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 14;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.PbUser_Click);
            // 
            // btUpload
            // 
            this.btUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btUpload.BackColor = System.Drawing.Color.DimGray;
            this.btUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpload.FlatAppearance.BorderSize = 0;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpload.Location = new System.Drawing.Point(639, 694);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(197, 55);
            this.btUpload.TabIndex = 28;
            this.btUpload.Text = "Upload de áudios";
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Click += new System.EventHandler(this.BtUpload_Click);
            this.btUpload.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtUpload_DragDrop);
            this.btUpload.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtUpload_DragEnter);
            this.btUpload.DragLeave += new System.EventHandler(this.BtUpload_DragLeave);
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
            this.barraSuperior1.Size = new System.Drawing.Size(1467, 30);
            this.barraSuperior1.TabIndex = 12;
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(773, 268);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 40);
            this.btEnter.TabIndex = 29;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 29);
            this.textBox1.TabIndex = 30;
            // 
            // MainPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btStopRec);
            this.Controls.Add(this.pbRec);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.pbTabs);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.pbImgConv);
            this.Controls.Add(this.pbConvert);
            this.Controls.Add(this.LbDown);
            this.Controls.Add(this.pbRightImg);
            this.Controls.Add(this.pbLeftImg);
            this.Controls.Add(this.btGrav);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.barraSuperior1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgConv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
        private BarraSuperior barraSuperior1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btGrav;
        private System.Windows.Forms.PictureBox pbLeftImg;
        private System.Windows.Forms.PictureBox pbRightImg;
        private System.Windows.Forms.Label LbDown;
        private System.Windows.Forms.PictureBox pbConvert;
        private System.Windows.Forms.PictureBox pbImgConv;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.PictureBox pbTabs;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbRec;
        private System.Windows.Forms.Button btStopRec;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox textBox1;
    }
}