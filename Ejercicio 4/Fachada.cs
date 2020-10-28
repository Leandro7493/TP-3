
namespace Ejercicio_4
{
    class Fachada
    {

        public string EncriptarAES (string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Desencriptar(palabra));
        }
    }
}
