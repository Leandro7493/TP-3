using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class Paciente
    {
        private string iNombre;

        private enumNiveles iNivel;

        public enumNiveles Nivel
        {
            get { return iNivel; }
            set { iNivel = value; }
        }

        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }
    }
}
