using System;
using System.Windows.Forms;

namespace ConsuDont
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            pgb.Minimum = 0;
            pgb.Maximum = 100;
            pgb.Value = 0;
            timerpgBar.Enabled = true;
        }

        private void timerpgBar_Tick(object sender, EventArgs e)
        {
            if (pgb.Value < pgb.Maximum)
            {
                pgb.Value += 2;
            }

            lblPorciento.Text = $"Cargando... {pgb.Value}%";

            if (pgb.Value >= pgb.Maximum)
            {
                timerpgBar.Stop();
                timerpgBar.Enabled = false;

                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}