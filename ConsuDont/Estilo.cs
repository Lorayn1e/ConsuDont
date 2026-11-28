using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsuDont
{
    /// <summary>
    /// Colores y estilos de ConsuDont en un solo lugar.
    /// Si quieres cambiar el look de toda la app, cambia los colores aquí.
    /// </summary>
    public static class Estilo
    {
        // ---- Colores ----
        public static readonly Color Menu = ColorTranslator.FromHtml("#0B2A4A");
        public static readonly Color MenuHover = ColorTranslator.FromHtml("#16406B");
        public static readonly Color MenuActivo = ColorTranslator.FromHtml("#1E4468");
        public static readonly Color MenuTexto = ColorTranslator.FromHtml("#D6E2EE");
        public static readonly Color Fondo = ColorTranslator.FromHtml("#F4F7FA");
        public static readonly Color Acento = ColorTranslator.FromHtml("#1FB5D4");
        public static readonly Color AcentoTexto = ColorTranslator.FromHtml("#062036");
        public static readonly Color Titulo = ColorTranslator.FromHtml("#0B2A4A");
        public static readonly Color Texto = ColorTranslator.FromHtml("#1F2937");
        public static readonly Color TextoSuave = ColorTranslator.FromHtml("#5B6B7B");
        public static readonly Color Borde = ColorTranslator.FromHtml("#E3E9EF");
        public static readonly Color BordeBoton = ColorTranslator.FromHtml("#D5DEE7");
        public static readonly Color Peligro = ColorTranslator.FromHtml("#FFA8A8");

        // ---- Fuentes (Segoe UI viene en todo Windows) ----
        private static readonly Font FuenteMenu = new Font("Segoe UI", 11F, FontStyle.Regular);
        private static readonly Font FuenteMenuActiva = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font FuenteTitulo = new Font("Segoe UI", 20F, FontStyle.Bold);
        public static readonly Font FuenteSubtitulo = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font FuenteNumero = new Font("Segoe UI", 22F, FontStyle.Bold);
        public static readonly Font FuenteEtiqueta = new Font("Segoe UI", 9.5F, FontStyle.Regular);

        // ---- Botón del menú lateral ----
        public static void BotonMenu(Button b, bool activo = false)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = MenuHover;
            b.FlatAppearance.MouseDownBackColor = MenuHover;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Padding = new Padding(14, 0, 0, 0);
            b.Height = 44;
            b.Cursor = Cursors.Hand;
            b.BackColor = activo ? MenuActivo : Menu;
            b.ForeColor = activo ? Color.White : MenuTexto;
            b.Font = activo ? FuenteMenuActiva : FuenteMenu;
        }

        // Marca un botón como activo y deja los demás normales.
        // A los botones con Tag = "salir" no los toca.
        public static void MarcarActivo(Panel menu, Button activo)
        {
            foreach (Control c in menu.Controls)
            {
                if (c is Button b && !"salir".Equals(b.Tag))
                    BotonMenu(b, b == activo);
            }
        }

        // Botón de "Cerrar sesión"
        public static void BotonSalir(Button b)
        {
            BotonMenu(b);
            b.Tag = "salir";
            b.ForeColor = Peligro;
        }

        // ---- Botones de acción ----
        public static void BotonPrimario(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Acento;
            b.ForeColor = AcentoTexto;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Height = 44;
            b.Cursor = Cursors.Hand;
        }

        public static void BotonSecundario(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = BordeBoton;
            b.BackColor = Color.White;
            b.ForeColor = Titulo;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Height = 44;
            b.Cursor = Cursors.Hand;
        }

        // ---- Tabla (DataGridView) limpia ----
        public static void TablaBonita(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Borde;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextoSuave;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.ForeColor = Texto;
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DDF5FA");
            dgv.DefaultCellStyle.SelectionForeColor = Texto;
            dgv.RowTemplate.Height = 44;

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

    /// <summary>
    /// Panel blanco con borde fino: la "tarjeta" del dashboard.
    /// Después de compilar, aparece en el Cuadro de herramientas para arrastrarla.
    /// </summary>
    public class Tarjeta : Panel
    {
        public Tarjeta()
        {
            BackColor = Color.White;
            Padding = new Padding(16);
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen lapiz = new Pen(Estilo.Borde))
            {
                e.Graphics.DrawRectangle(lapiz, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}