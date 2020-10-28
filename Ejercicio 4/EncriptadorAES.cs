using System;

namespace Ejercicio_4
{
    public class EncriptadorAES : Encriptador
    {
        public EncriptadorAES() : base("AES") { }

        public override string Encriptar(string pCadena)
        {
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pCadena);
            resultado = Convert.ToBase64String(encryted);
            return resultado;
        }

        public override string Desencriptar(string pCadena)
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(pCadena);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;

        }
    }
}