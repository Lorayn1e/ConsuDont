using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsuDont
{
    public partial class UCCitas : UserControl
    {

        private DateTime mesActual = DateTime.Today;

        private void CargarCalendario()
        {
            tlpDiasCalendario.Controls.Clear();

            tlpDiasCalendario.ColumnCount = 7;
            tlpDiasCalendario.RowCount = 6;

            DateTime primerDia = new DateTime(
                mesActual.Year,
                mesActual.Month,
                1
            );

            int diasMes = DateTime.DaysInMonth(
                mesActual.Year,
                mesActual.Month
            );

            // Ajustar para que la semana comience el lunes
            int desplazamiento = ((int)primerDia.DayOfWeek + 6) % 7;

            for (int dia = 1; dia <= diasMes; dia++)
            {
                int posicion = desplazamiento + dia - 1;

                int fila = posicion / 7;
                int columna = posicion % 7;

                Button btn = new Button();

                btn.Text = dia.ToString();
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(1, 10, 61);
                btn.Font = new Font("Segoe UI", 10);

                tlpDiasCalendario.Controls.Add(btn, columna, fila);
            }
        }

        public UCCitas()
        {
            InitializeComponent();
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
