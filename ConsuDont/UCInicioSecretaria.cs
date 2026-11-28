using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ConsuDont
{
    public partial class UCInicioSecretaria : UserControl
    {
        private readonly Font negrita = new Font("Gadugi", 8F, FontStyle.Bold);

        public UCInicioSecretaria()
        {
            InitializeComponent();
        }

        private void UCInicioSecretaria_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;      // evita que busque datos mientras diseñas
            CargarAgenda();
            CargarPendientes();
            dgvAgenda.CellFormatting += dgvAgenda_CellFormatting;
        }

        private void CargarAgenda()
        {
            string sql = @"
        SELECT CONVERT(varchar(5), C.FechaHoraInicio, 108) AS Hora,
               P.Nombre + ' ' + P.Apellido AS Paciente,
               S.Nombre AS Servicio,
               O.Apellidos AS Odontologo,
               E.Nombre AS Estado
        FROM Citas C
        INNER JOIN Pacientes   P ON P.IdPaciente   = C.IdPaciente
        INNER JOIN Servicios   S ON S.IdServicio   = C.IdServicio
        INNER JOIN Odontologos O ON O.IdOdontologo = C.IdOdontologo
        INNER JOIN EstadosCita E ON E.IdEstado     = C.IdEstado
        WHERE CAST(C.FechaHoraInicio AS DATE) = CAST(GETDATE() AS DATE)
          AND E.Nombre <> 'Cancelada'
        ORDER BY C.FechaHoraInicio";

            try
            {
                DataTable tabla = new DataTable();

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conn))
                {
                    adaptador.Fill(tabla);
                }

                dgvAgenda.DataSource = tabla;
                Estilo.TablaBonita(dgvAgenda);
                dgvAgenda.Columns["Odontologo"].HeaderText = "Odontólogo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la agenda: " + ex.Message);
            }
        }

        private void CargarPendientes()
        {
            string sql = @"
        SELECT C.FechaHoraInicio AS Cuando,
               P.Nombre + ' ' + P.Apellido AS Paciente
        FROM Citas C
        INNER JOIN Pacientes   P ON P.IdPaciente = C.IdPaciente
        INNER JOIN EstadosCita E ON E.IdEstado   = C.IdEstado
        WHERE E.Nombre = 'Pendiente'
          AND C.FechaHoraInicio >= GETDATE()
          AND C.FechaHoraInicio <  DATEADD(DAY, 7, GETDATE())
        ORDER BY C.FechaHoraInicio";

            try
            {
                DataTable tabla = new DataTable();

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conn))
                {
                    adaptador.Fill(tabla);
                }

                dgvPendientes.DataSource = tabla;
                Estilo.TablaBonita(dgvPendientes);

                dgvPendientes.Columns["Cuando"].HeaderText = "Cuándo";
                dgvPendientes.Columns["Cuando"].DefaultCellStyle.Format = "ddd dd/MM · HH:mm";
                dgvPendientes.Columns["Cuando"].FillWeight = 55;
                dgvPendientes.Columns["Paciente"].FillWeight = 45;
                dgvPendientes.ClearSelection();

                lblPendientes.Text = tabla.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las citas por confirmar: " + ex.Message);
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void dgvAgenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || dgvAgenda.Columns[e.ColumnIndex].Name != "Estado") return;

            switch (e.Value.ToString())
            {
                case "Completada": e.CellStyle.ForeColor = ColorTranslator.FromHtml("#14683A"); break;
                case "Confirmada": e.CellStyle.ForeColor = ColorTranslator.FromHtml("#0B6478"); break;
                case "Pendiente": e.CellStyle.ForeColor = ColorTranslator.FromHtml("#7A4E00"); break;
                case "Cancelada": e.CellStyle.ForeColor = ColorTranslator.FromHtml("#9B2C2C"); break;
                case "No asistio": e.CellStyle.ForeColor = ColorTranslator.FromHtml("#4A5764"); break;
            }
            e.CellStyle.Font = new Font(dgvAgenda.Font, FontStyle.Bold);
        }
    }
}