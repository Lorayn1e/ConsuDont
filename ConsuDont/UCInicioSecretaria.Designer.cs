namespace ConsuDont
{
    partial class UCInicioSecretaria
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tarAgenda = new ConsuDont.Tarjeta();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.llblAgenda = new System.Windows.Forms.LinkLabel();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.tarLista = new ConsuDont.Tarjeta();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.tarAccesos = new ConsuDont.Tarjeta();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblAccesos = new System.Windows.Forms.Label();
            this.tarPróxima = new ConsuDont.Tarjeta();
            this.lblNPróxima = new System.Windows.Forms.Label();
            this.lblPróximaDetalle = new System.Windows.Forms.Label();
            this.lblPróxima = new System.Windows.Forms.Label();
            this.tarsPendiente = new ConsuDont.Tarjeta();
            this.lblNPendiente = new System.Windows.Forms.Label();
            this.lblPendienteDetalle = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.tarCitas = new ConsuDont.Tarjeta();
            this.lblNCitas = new System.Windows.Forms.Label();
            this.lblCitaDetalle = new System.Windows.Forms.Label();
            this.lblCitasdehoy = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tarAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.tarLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.tarAccesos.SuspendLayout();
            this.tarPróxima.SuspendLayout();
            this.tarsPendiente.SuspendLayout();
            this.tarCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Interval = 500;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(365, 38);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenid@, Secretario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFecha.Location = new System.Drawing.Point(745, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 19);
            this.lblFecha.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(849, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 24);
            this.lblHora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Esto es lo que hay para hoy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tarPróxima, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tarsPendiente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tarCitas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 147);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tarAgenda
            // 
            this.tarAgenda.BackColor = System.Drawing.Color.White;
            this.tarAgenda.Controls.Add(this.lblAgenda);
            this.tarAgenda.Controls.Add(this.llblAgenda);
            this.tarAgenda.Controls.Add(this.dgvAgenda);
            this.tarAgenda.Location = new System.Drawing.Point(6, 302);
            this.tarAgenda.Name = "tarAgenda";
            this.tarAgenda.Padding = new System.Windows.Forms.Padding(16);
            this.tarAgenda.Size = new System.Drawing.Size(668, 384);
            this.tarAgenda.TabIndex = 14;
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.Black;
            this.lblAgenda.Location = new System.Drawing.Point(9, 16);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(152, 24);
            this.lblAgenda.TabIndex = 9;
            this.lblAgenda.Text = "Agenda de hoy";
            // 
            // llblAgenda
            // 
            this.llblAgenda.AutoSize = true;
            this.llblAgenda.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAgenda.Location = new System.Drawing.Point(516, 30);
            this.llblAgenda.Name = "llblAgenda";
            this.llblAgenda.Size = new System.Drawing.Size(133, 19);
            this.llblAgenda.TabIndex = 1;
            this.llblAgenda.TabStop = true;
            this.llblAgenda.Text = "Ver todas las citas";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(13, 69);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersWidth = 62;
            this.dgvAgenda.RowTemplate.Height = 28;
            this.dgvAgenda.Size = new System.Drawing.Size(642, 302);
            this.dgvAgenda.TabIndex = 0;
            // 
            // tarLista
            // 
            this.tarLista.BackColor = System.Drawing.Color.White;
            this.tarLista.Controls.Add(this.lblLista);
            this.tarLista.Controls.Add(this.dgvPendientes);
            this.tarLista.Location = new System.Drawing.Point(680, 511);
            this.tarLista.Name = "tarLista";
            this.tarLista.Padding = new System.Windows.Forms.Padding(16);
            this.tarLista.Size = new System.Drawing.Size(333, 194);
            this.tarLista.TabIndex = 12;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.Color.Black;
            this.lblLista.Location = new System.Drawing.Point(7, 16);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(141, 24);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "Por confirmar";
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Location = new System.Drawing.Point(8, 53);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.RowHeadersWidth = 62;
            this.dgvPendientes.RowTemplate.Height = 28;
            this.dgvPendientes.Size = new System.Drawing.Size(318, 122);
            this.dgvPendientes.TabIndex = 0;
            // 
            // tarAccesos
            // 
            this.tarAccesos.BackColor = System.Drawing.Color.White;
            this.tarAccesos.Controls.Add(this.btnHorarios);
            this.tarAccesos.Controls.Add(this.btnRegistrar);
            this.tarAccesos.Controls.Add(this.lblAccesos);
            this.tarAccesos.Location = new System.Drawing.Point(680, 274);
            this.tarAccesos.Name = "tarAccesos";
            this.tarAccesos.Padding = new System.Windows.Forms.Padding(16);
            this.tarAccesos.Size = new System.Drawing.Size(333, 211);
            this.tarAccesos.TabIndex = 12;
            // 
            // btnHorarios
            // 
            this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarios.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHorarios.Location = new System.Drawing.Point(11, 138);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(315, 48);
            this.btnHorarios.TabIndex = 12;
            this.btnHorarios.Text = "Ver horarios";
            this.btnHorarios.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegistrar.Location = new System.Drawing.Point(11, 69);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(315, 48);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar paciente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblAccesos
            // 
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesos.ForeColor = System.Drawing.Color.Black;
            this.lblAccesos.Location = new System.Drawing.Point(7, 25);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(152, 24);
            this.lblAccesos.TabIndex = 10;
            this.lblAccesos.Text = "Agenda de hoy";
            // 
            // tarPróxima
            // 
            this.tarPróxima.BackColor = System.Drawing.Color.White;
            this.tarPróxima.Controls.Add(this.lblNPróxima);
            this.tarPróxima.Controls.Add(this.lblPróximaDetalle);
            this.tarPróxima.Controls.Add(this.lblPróxima);
            this.tarPróxima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarPróxima.Location = new System.Drawing.Point(677, 3);
            this.tarPróxima.Name = "tarPróxima";
            this.tarPróxima.Padding = new System.Windows.Forms.Padding(16);
            this.tarPróxima.Size = new System.Drawing.Size(333, 141);
            this.tarPróxima.TabIndex = 10;
            // 
            // lblNPróxima
            // 
            this.lblNPróxima.AutoSize = true;
            this.lblNPróxima.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPróxima.ForeColor = System.Drawing.Color.Black;
            this.lblNPróxima.Location = new System.Drawing.Point(19, 54);
            this.lblNPróxima.Name = "lblNPróxima";
            this.lblNPróxima.Size = new System.Drawing.Size(35, 38);
            this.lblNPróxima.TabIndex = 11;
            this.lblNPróxima.Text = "5";
            // 
            // lblPróximaDetalle
            // 
            this.lblPróximaDetalle.AutoSize = true;
            this.lblPróximaDetalle.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPróximaDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblPróximaDetalle.Location = new System.Drawing.Point(7, 106);
            this.lblPróximaDetalle.Name = "lblPróximaDetalle";
            this.lblPróximaDetalle.Size = new System.Drawing.Size(94, 19);
            this.lblPróximaDetalle.TabIndex = 10;
            this.lblPróximaDetalle.Text = "Próxima cita";
            // 
            // lblPróxima
            // 
            this.lblPróxima.AutoSize = true;
            this.lblPróxima.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPróxima.ForeColor = System.Drawing.Color.Gray;
            this.lblPróxima.Location = new System.Drawing.Point(7, 16);
            this.lblPróxima.Name = "lblPróxima";
            this.lblPróxima.Size = new System.Drawing.Size(129, 24);
            this.lblPróxima.TabIndex = 8;
            this.lblPróxima.Text = "Próxima cita";
            // 
            // tarsPendiente
            // 
            this.tarsPendiente.BackColor = System.Drawing.Color.White;
            this.tarsPendiente.Controls.Add(this.lblNPendiente);
            this.tarsPendiente.Controls.Add(this.lblPendienteDetalle);
            this.tarsPendiente.Controls.Add(this.lblPendientes);
            this.tarsPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarsPendiente.Location = new System.Drawing.Point(340, 3);
            this.tarsPendiente.Name = "tarsPendiente";
            this.tarsPendiente.Padding = new System.Windows.Forms.Padding(16);
            this.tarsPendiente.Size = new System.Drawing.Size(331, 141);
            this.tarsPendiente.TabIndex = 10;
            // 
            // lblNPendiente
            // 
            this.lblNPendiente.AutoSize = true;
            this.lblNPendiente.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPendiente.ForeColor = System.Drawing.Color.Black;
            this.lblNPendiente.Location = new System.Drawing.Point(16, 54);
            this.lblNPendiente.Name = "lblNPendiente";
            this.lblNPendiente.Size = new System.Drawing.Size(35, 38);
            this.lblNPendiente.TabIndex = 11;
            this.lblNPendiente.Text = "5";
            // 
            // lblPendienteDetalle
            // 
            this.lblPendienteDetalle.AutoSize = true;
            this.lblPendienteDetalle.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendienteDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblPendienteDetalle.Location = new System.Drawing.Point(19, 106);
            this.lblPendienteDetalle.Name = "lblPendienteDetalle";
            this.lblPendienteDetalle.Size = new System.Drawing.Size(94, 19);
            this.lblPendienteDetalle.TabIndex = 10;
            this.lblPendienteDetalle.Text = "Próxima cita";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.ForeColor = System.Drawing.Color.Gray;
            this.lblPendientes.Location = new System.Drawing.Point(19, 16);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(141, 24);
            this.lblPendientes.TabIndex = 8;
            this.lblPendientes.Text = "Por confirmar";
            // 
            // tarCitas
            // 
            this.tarCitas.BackColor = System.Drawing.Color.White;
            this.tarCitas.Controls.Add(this.lblNCitas);
            this.tarCitas.Controls.Add(this.lblCitaDetalle);
            this.tarCitas.Controls.Add(this.lblCitasdehoy);
            this.tarCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarCitas.Location = new System.Drawing.Point(3, 3);
            this.tarCitas.Name = "tarCitas";
            this.tarCitas.Padding = new System.Windows.Forms.Padding(16);
            this.tarCitas.Size = new System.Drawing.Size(331, 141);
            this.tarCitas.TabIndex = 9;
            // 
            // lblNCitas
            // 
            this.lblNCitas.AutoSize = true;
            this.lblNCitas.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCitas.ForeColor = System.Drawing.Color.Black;
            this.lblNCitas.Location = new System.Drawing.Point(19, 54);
            this.lblNCitas.Name = "lblNCitas";
            this.lblNCitas.Size = new System.Drawing.Size(35, 38);
            this.lblNCitas.TabIndex = 10;
            this.lblNCitas.Text = "5";
            // 
            // lblCitaDetalle
            // 
            this.lblCitaDetalle.AutoSize = true;
            this.lblCitaDetalle.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitaDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblCitaDetalle.Location = new System.Drawing.Point(9, 106);
            this.lblCitaDetalle.Name = "lblCitaDetalle";
            this.lblCitaDetalle.Size = new System.Drawing.Size(94, 19);
            this.lblCitaDetalle.TabIndex = 9;
            this.lblCitaDetalle.Text = "Próxima cita";
            // 
            // lblCitasdehoy
            // 
            this.lblCitasdehoy.AutoSize = true;
            this.lblCitasdehoy.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasdehoy.ForeColor = System.Drawing.Color.Gray;
            this.lblCitasdehoy.Location = new System.Drawing.Point(9, 16);
            this.lblCitasdehoy.Name = "lblCitasdehoy";
            this.lblCitasdehoy.Size = new System.Drawing.Size(126, 24);
            this.lblCitasdehoy.TabIndex = 7;
            this.lblCitasdehoy.Text = "Citas de hoy";
            // 
            // UCInicioSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tarAgenda);
            this.Controls.Add(this.tarLista);
            this.Controls.Add(this.tarAccesos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UCInicioSecretaria";
            this.Size = new System.Drawing.Size(1019, 844);
            this.Load += new System.EventHandler(this.UCInicioSecretaria_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tarAgenda.ResumeLayout(false);
            this.tarAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.tarLista.ResumeLayout(false);
            this.tarLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.tarAccesos.ResumeLayout(false);
            this.tarAccesos.PerformLayout();
            this.tarPróxima.ResumeLayout(false);
            this.tarPróxima.PerformLayout();
            this.tarsPendiente.ResumeLayout(false);
            this.tarsPendiente.PerformLayout();
            this.tarCitas.ResumeLayout(false);
            this.tarCitas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private Tarjeta tarCitas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Tarjeta tarPróxima;
        private Tarjeta tarsPendiente;
        private Tarjeta tarAccesos;
        private Tarjeta tarLista;
        private System.Windows.Forms.Label lblCitasdehoy;
        private System.Windows.Forms.Label lblPróximaDetalle;
        private System.Windows.Forms.Label lblPróxima;
        private System.Windows.Forms.Label lblPendienteDetalle;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblNCitas;
        private System.Windows.Forms.Label lblCitaDetalle;
        private System.Windows.Forms.Label lblNPróxima;
        private System.Windows.Forms.Label lblNPendiente;
        private Tarjeta tarAgenda;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.LinkLabel llblAgenda;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAccesos;
    }
}
