using System;

namespace Ejercicio_4
{
    public abstract class Encriptador : IEncriptador
    {
        private string iNombre;

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }

        public abstract string Encriptar(string pCadena);
        public abstract string Desencriptar(string pCadena);

    }
}
