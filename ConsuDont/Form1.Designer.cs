namespace ConsuDont
{
    partial class Splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timerpgBar = new System.Windows.Forms.Timer(this.components);
            this.pcbSplash = new System.Windows.Forms.PictureBox();
            this.lblPorciento = new System.Windows.Forms.Label();
            this.pgBar = new ModernProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timerpgBar
            // 
            this.timerpgBar.Enabled = true;
            this.timerpgBar.Tick += new System.EventHandler(this.timerpgBar_Tick);
            // 
            // pcbSplash
            // 
            this.pcbSplash.BackColor = System.Drawing.Color.Transparent;
            this.pcbSplash.Image = global::ConsuDont.Properties.Resources.logo;
            this.pcbSplash.Location = new System.Drawing.Point(276, 31);
            this.pcbSplash.Name = "pcbSplash";
            this.pcbSplash.Size = new System.Drawing.Size(727, 576);
            this.pcbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSplash.TabIndex = 4;
            this.pcbSplash.TabStop = false;
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.BackColor = System.Drawing.Color.Transparent;
            this.lblPorciento.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorciento.ForeColor = System.Drawing.Color.White;
            this.lblPorciento.Location = new System.Drawing.Point(544, 560);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(76, 28);
            this.lblPorciento.TabIndex = 5;
            this.lblPorciento.Text = "label1";
            // 
            // pgBar
            // 
            this.pgBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.pgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgBar.FillColor = System.Drawing.Color.SteelBlue;
            this.pgBar.ForeColor = System.Drawing.Color.White;
            this.pgBar.Location = new System.Drawing.Point(0, 741);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(1278, 23);
            this.pgBar.TabIndex = 3;
            this.pgBar.TrackColor = System.Drawing.Color.Transparent;
            this.pgBar.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsuDont.Properties.Resources.Splashimage;
            this.ClientSize = new System.Drawing.Size(1278, 764);
            this.Controls.Add(this.lblPorciento);
            this.Controls.Add(this.pcbSplash);
            this.Controls.Add(this.pgBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerpgBar;
        private ModernProgressBar pgBar;
        private System.Windows.Forms.PictureBox pcbSplash;
        private System.Windows.Forms.Label lblPorciento;
    }
}

