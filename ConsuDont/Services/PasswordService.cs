using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsuDont
{
    public class PasswordService
    { 

        private const int Iteraciones = 210000;

        public static string CrearHash(string password)
        {
            byte[] salt = new byte[16];

            using (var generador = RandomNumberGenerator.Create())
            {
                generador.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, Iteraciones, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Iteraciones + ":" +
                    Convert.ToBase64String(salt) + ":" +
                    Convert.ToBase64String(hash);
            }
        }

        public static bool VerificarPassword(
            string password, string hashGuardado)
        {
            try
            {
                string[] partes = hashGuardado.Split(':');

                int iteraciones = int.Parse(partes[0]);
                byte[] salt = Convert.FromBase64String(partes[1]);
                byte[] hashOriginal = Convert.FromBase64String(partes[2]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(
                    password, salt, iteraciones, HashAlgorithmName.SHA256))
                {
                    byte[] hashNuevo =
                        pbkdf2.GetBytes(hashOriginal.Length);

                    int diferencia = 0;

                    for (int i = 0; i < hashOriginal.Length; i++)
                    {
                        diferencia |= hashOriginal[i] ^ hashNuevo[i];
                    }

                    return diferencia == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}