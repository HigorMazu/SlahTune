namespace SlahTune
{
    partial class BarraSuperior
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Topo = new System.Windows.Forms.Label();
            this.BotMini = new System.Windows.Forms.Button();
            this.BotMaxJan = new System.Windows.Forms.Button();
            this.BotFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Topo
            // 
            this.Topo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Topo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Topo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Topo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Topo.Location = new System.Drawing.Point(0, 0);
            this.Topo.Name = "Topo";
            this.Topo.Size = new System.Drawing.Size(649, 29);
            this.Topo.TabIndex = 4;
            this.Topo.Text = " Topo";
            this.Topo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Topo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topo_MouseDown);
            this.Topo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topo_MouseMove);
            this.Topo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topo_MouseUp);
            // 
            // BotMini
            // 
            this.BotMini.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BotMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotMini.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotMini.Location = new System.Drawing.Point(490, 0);
            this.BotMini.Name = "BotMini";
            this.BotMini.Size = new System.Drawing.Size(53, 29);
            this.BotMini.TabIndex = 7;
            this.BotMini.Text = "🗕";
            this.BotMini.UseVisualStyleBackColor = false;
            this.BotMini.Click += new System.EventHandler(this.BotMini_Click);
            // 
            // BotMaxJan
            // 
            this.BotMaxJan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BotMaxJan.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotMaxJan.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotMaxJan.Location = new System.Drawing.Point(543, 0);
            this.BotMaxJan.Name = "BotMaxJan";
            this.BotMaxJan.Size = new System.Drawing.Size(53, 29);
            this.BotMaxJan.TabIndex = 6;
            this.BotMaxJan.Text = "🗖";
            this.BotMaxJan.UseVisualStyleBackColor = false;
            this.BotMaxJan.Click += new System.EventHandler(this.BotMaxJan_Click);
            // 
            // BotFechar
            // 
            this.BotFechar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BotFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotFechar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotFechar.Location = new System.Drawing.Point(596, 0);
            this.BotFechar.Name = "BotFechar";
            this.BotFechar.Size = new System.Drawing.Size(53, 29);
            this.BotFechar.TabIndex = 5;
            this.BotFechar.Text = "X";
            this.BotFechar.UseVisualStyleBackColor = false;
            this.BotFechar.Click += new System.EventHandler(this.BotFechar_Click);
            // 
            // BarraSuperior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BotMini);
            this.Controls.Add(this.BotMaxJan);
            this.Controls.Add(this.BotFechar);
            this.Controls.Add(this.Topo);
            this.Name = "BarraSuperior";
            this.Size = new System.Drawing.Size(649, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Topo;
        private System.Windows.Forms.Button BotMini;
        private System.Windows.Forms.Button BotMaxJan;
        private System.Windows.Forms.Button BotFechar;
    }
}
