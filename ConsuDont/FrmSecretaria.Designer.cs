namespace ConsuDont
{
    partial class FrmSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaria));
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.picbInicio = new System.Windows.Forms.PictureBox();
            this.pcbPacientes = new System.Windows.Forms.PictureBox();
            this.btnSesión = new System.Windows.Forms.Button();
            this.pcbCitas = new System.Windows.Forms.PictureBox();
            this.pcbHorarios = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(259, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1019, 832);
            this.pnlContenido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario conectado: Secretaria";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::ConsuDont.Properties.Resources.logo2;
            this.pcbLogo.Location = new System.Drawing.Point(-15, -35);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(274, 199);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(6, 170);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(247, 63);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPacientes.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(6, 261);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(247, 63);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHorarios.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(6, 447);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(247, 63);
            this.btnHorarios.TabIndex = 5;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCitas.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Location = new System.Drawing.Point(6, 353);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(247, 63);
            this.btnCitas.TabIndex = 8;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // picbInicio
            // 
            this.picbInicio.Image = global::ConsuDont.Properties.Resources.Inicio;
            this.picbInicio.Location = new System.Drawing.Point(12, 182);
            this.picbInicio.Name = "picbInicio";
            this.picbInicio.Size = new System.Drawing.Size(49, 43);
            this.picbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbInicio.TabIndex = 2;
            this.picbInicio.TabStop = false;
            // 
            // pcbPacientes
            // 
            this.pcbPacientes.Image = global::ConsuDont.Properties.Resources.Pacientes;
            this.pcbPacientes.Location = new System.Drawing.Point(12, 272);
            this.pcbPacientes.Name = "pcbPacientes";
            this.pcbPacientes.Size = new System.Drawing.Size(49, 43);
            this.pcbPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPacientes.TabIndex = 10;
            this.pcbPacientes.TabStop = false;
            // 
            // btnSesión
            // 
            this.btnSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.btnSesión.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSesión.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesión.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSesión.Location = new System.Drawing.Point(6, 711);
            this.btnSesión.Name = "btnSesión";
            this.btnSesión.Size = new System.Drawing.Size(247, 62);
            this.btnSesión.TabIndex = 9;
            this.btnSesión.Text = "Cerrar Sesión";
            this.btnSesión.UseVisualStyleBackColor = false;
            // 
            // pcbCitas
            // 
            this.pcbCitas.Image = global::ConsuDont.Properties.Resources.cc5936abd8464bae801d6677b270c35f_removebg_preview;
            this.pcbCitas.Location = new System.Drawing.Point(12, 364);
            this.pcbCitas.Name = "pcbCitas";
            this.pcbCitas.Size = new System.Drawing.Size(49, 43);
            this.pcbCitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCitas.TabIndex = 3;
            this.pcbCitas.TabStop = false;
            // 
            // pcbHorarios
            // 
            this.pcbHorarios.Image = global::ConsuDont.Properties.Resources.horario;
            this.pcbHorarios.Location = new System.Drawing.Point(12, 458);
            this.pcbHorarios.Name = "pcbHorarios";
            this.pcbHorarios.Size = new System.Drawing.Size(49, 43);
            this.pcbHorarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHorarios.TabIndex = 12;
            this.pcbHorarios.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsuDont.Properties.Resources.logout_exit;
            this.pictureBox1.Location = new System.Drawing.Point(12, 721);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 656);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Laura Gómez";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(61)))));
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.pcbHorarios);
            this.pnlMenu.Controls.Add(this.pcbCitas);
            this.pnlMenu.Controls.Add(this.btnSesión);
            this.pnlMenu.Controls.Add(this.pcbPacientes);
            this.pnlMenu.Controls.Add(this.picbInicio);
            this.pnlMenu.Controls.Add(this.btnCitas);
            this.pnlMenu.Controls.Add(this.btnHorarios);
            this.pnlMenu.Controls.Add(this.btnPacientes);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.pcbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(259, 832);
            this.pnlMenu.TabIndex = 2;
            // 
            // FrmSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 832);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.PictureBox picbInicio;
        private System.Windows.Forms.PictureBox pcbPacientes;
        private System.Windows.Forms.Button btnSesión;
        private System.Windows.Forms.PictureBox pcbCitas;
        private System.Windows.Forms.PictureBox pcbHorarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlMenu;
    }
}