namespace SlahTune
{
    partial class SelMicPg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CbMic = new System.Windows.Forms.ComboBox();
            this.BotGrav = new System.Windows.Forms.Button();
            this.barraSuperior1 = new SlahTune.BarraSuperior();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o microfone";
            // 
            // CbMic
            // 
            this.CbMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CbMic.FormattingEnabled = true;
            this.CbMic.Location = new System.Drawing.Point(239, 57);
            this.CbMic.Name = "CbMic";
            this.CbMic.Size = new System.Drawing.Size(223, 26);
            this.CbMic.TabIndex = 1;
            // 
            // BotGrav
            // 
            this.BotGrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BotGrav.Location = new System.Drawing.Point(239, 111);
            this.BotGrav.Name = "BotGrav";
            this.BotGrav.Size = new System.Drawing.Size(75, 39);
            this.BotGrav.TabIndex = 2;
            this.BotGrav.Text = "Ok";
            this.BotGrav.UseVisualStyleBackColor = true;
            this.BotGrav.Click += new System.EventHandler(this.BotGrav_Click);
            // 
            // barraSuperior1
            // 
            this.barraSuperior1.BarText = "Seletor de Dispositivos";
            this.barraSuperior1.CloseApplicationOnCloseForm = false;
            this.barraSuperior1.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior1.Name = "barraSuperior1";
            this.barraSuperior1.ShowMaximizeButton = false;
            this.barraSuperior1.ShowMinimizeButton = true;
            this.barraSuperior1.Size = new System.Drawing.Size(539, 27);
            this.barraSuperior1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlahTune.Properties.Resources.MicImg;
            this.pictureBox1.Location = new System.Drawing.Point(483, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SelMic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(540, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraSuperior1);
            this.Controls.Add(this.BotGrav);
            this.Controls.Add(this.CbMic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelMic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbMic;
        private System.Windows.Forms.Button BotGrav;
        private BarraSuperior barraSuperior1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}