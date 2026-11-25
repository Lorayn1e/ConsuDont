namespace ConsuDont
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.lblSesión = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescripción2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(610, 551);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(478, 44);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(610, 266);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(479, 26);
            this.txtCorreo.TabIndex = 55;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(605, 235);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(90, 28);
            this.lblCorreo.TabIndex = 54;
            this.lblCorreo.Text = "Correo";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.Location = new System.Drawing.Point(609, 372);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(479, 26);
            this.txtContrasena.TabIndex = 53;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(604, 331);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(141, 28);
            this.lblContrasena.TabIndex = 52;
            this.lblContrasena.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(609, 484);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(479, 44);
            this.btnEntrar.TabIndex = 51;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrar.Location = new System.Drawing.Point(610, 431);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(173, 24);
            this.chkMostrar.TabIndex = 50;
            this.chkMostrar.Text = "Mostrar contraseña";
            this.chkMostrar.UseVisualStyleBackColor = false;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged_1);
            // 
            // lblSesión
            // 
            this.lblSesión.AutoSize = true;
            this.lblSesión.BackColor = System.Drawing.Color.Transparent;
            this.lblSesión.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesión.Location = new System.Drawing.Point(602, 92);
            this.lblSesión.Name = "lblSesión";
            this.lblSesión.Size = new System.Drawing.Size(215, 38);
            this.lblSesión.TabIndex = 48;
            this.lblSesión.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDescripción);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.lblSesión);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.lblContrasena);
            this.panel1.Controls.Add(this.chkMostrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 704);
            this.panel1.TabIndex = 59;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripción.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(605, 147);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(370, 27);
            this.lblDescripción.TabIndex = 58;
            this.lblDescripción.Text = "Ingresa tus credenciales para continuar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblDescripción2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 704);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ConsuDont.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescripción2
            // 
            this.lblDescripción2.AutoSize = true;
            this.lblDescripción2.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripción2.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción2.ForeColor = System.Drawing.Color.White;
            this.lblDescripción2.Location = new System.Drawing.Point(35, 643);
            this.lblDescripción2.Name = "lblDescripción2";
            this.lblDescripción2.Size = new System.Drawing.Size(289, 27);
            this.lblDescripción2.TabIndex = 59;
            this.lblDescripción2.Text = "Gestión de citas | Ondontología";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Label lblSesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblDescripción2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}