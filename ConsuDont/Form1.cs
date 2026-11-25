using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsuDont
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerpgBar_Tick(object sender, EventArgs e)
        {
            timerpgBar.Enabled = true;
            pgBar.Increment(2);
            lblPorciento.Text = "Cargando..." + pgBar.Value.ToString() + "%";

            if (pgBar.Value == 100)
            {
                timerpgBar.Enabled = false;
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

       
    }
}
