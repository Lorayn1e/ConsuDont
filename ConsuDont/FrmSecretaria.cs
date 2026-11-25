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
    public partial class FrmSecretaria : Form
    {
        public FrmSecretaria()
        {
            InitializeComponent();

            CargarSeccion(new UCInicioSecretaria());
        }

        private void CargarSeccion(UserControl seccion)
        {
            pnlContenido.Controls.Clear();

            seccion.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(seccion);
        }


        private void btnPacientes_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCCitas());

        }

        private void btnOdontólogos_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCOdontologos());

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCServicios());

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCHorarios());

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarSeccion(new UCInicioSecretaria());

        }

        
    }
}
