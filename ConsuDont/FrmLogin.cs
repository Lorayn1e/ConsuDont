using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsuDont
{
    public partial class FrmLogin : Form
    {
        private string rutaRecordar =
            Path.Combine(Application.UserAppDataPath, "login.txt");

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Completa el correo y la contraseña.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    string consulta = @"
                SELECT
                    U.IdUsuario,
                    U.Correo,
                    U.PasswordHash,
                    R.Nombre AS Rol
                FROM Usuarios U
                INNER JOIN Roles R
                    ON U.IdRol = R.IdRol
                WHERE U.Correo = @Correo
                AND U.Estado = 'Activo'";

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100)
                            .Value = txtCorreo.Text.Trim();

                        conn.Open();

                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                string hashGuardado =
                                    lector["PasswordHash"].ToString();

                                bool contraseñaCorrecta =
                                    PasswordService.VerificarPassword(
                                        txtContrasena.Text, hashGuardado);

                                if (!contraseñaCorrecta)
                                {
                                    MessageBox.Show(
                                        "Correo o contraseña incorrectos.");

                                    txtContrasena.Clear();
                                    txtContrasena.Focus();
                                    return;
                                }

                                Usuario usuario = new Usuario
                                {
                                    IdUsuario = Convert.ToInt32(
                                        lector["IdUsuario"]),

                                    Correo = lector["Correo"].ToString(),

                                    PasswordHash = hashGuardado,

                                    Rol = lector["Rol"].ToString()
                                };

                                // Guardamos quién inició sesión (paso 3)
                                Sesion.UsuarioActual = usuario;

                                // Recordar usuario: solo si el login fue correcto (paso 4)
                                if (chkMostrar.Checked)
                                {
                                    File.WriteAllText(rutaRecordar, txtCorreo.Text.Trim());
                                }

                                AbrirPanel(usuario);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Correo o contraseña incorrectos.");

                                txtContrasena.Clear();
                                txtContrasena.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión: " + ex.Message);
            }
        }

        private void chkMostrar_CheckedChanged_1(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
        }
    
        private void AbrirPanel(Usuario usuario)
        {
            Form panel = null;

            if (usuario.Rol == "Administrador")
            {
                panel = new FrmAdmin();
            }
            else if (usuario.Rol == "Secretaria")
            {
                panel = new FrmSecretaria();
            }
            else
            {
                MessageBox.Show("Este usuario no tiene un rol autorizado.");
                return;
            }

            panel.FormClosed += (s, args) => this.Close();

            this.Hide();
            panel.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            txtContrasena.Clear();

            txtCorreo.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(rutaRecordar))
            {
                txtCorreo.Text = File.ReadAllText(rutaRecordar);
                chkMostrar.Checked = true;
            }


            CrearUsuariosIniciales();
        }

        private void CrearUsuariosIniciales()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();

                    using (SqlCommand contar = new SqlCommand("SELECT COUNT(*) FROM Usuarios", conn))
                    {
                        if ((int)contar.ExecuteScalar() > 0) return;   // ya hay usuarios, no hace nada
                    }

                    InsertarUsuario(conn, "Admin", "Sistema", "admin@consudont.com", "Admin123!", 1);
                    InsertarUsuario(conn, "Laura", "Gómez", "secretaria@consudont.com", "Secre123!", 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo preparar la base de datos: " + ex.Message);
            }
        }

        private void InsertarUsuario(SqlConnection conn, string nombres, string apellidos,
                                     string correo, string password, int idRol)
        {
            using (SqlCommand cmd = new SqlCommand(@"
        INSERT INTO Usuarios (Nombres, Apellidos, Correo, PasswordHash, IdRol)
        VALUES (@Nombres, @Apellidos, @Correo, @Hash, @IdRol)", conn))
            {
                cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar, 60).Value = nombres;
                cmd.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 60).Value = apellidos;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = correo;
                cmd.Parameters.Add("@Hash", SqlDbType.VarChar, 255).Value = PasswordService.CrearHash(password);
                cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
                cmd.ExecuteNonQuery();
            }
        }

    }
    }
