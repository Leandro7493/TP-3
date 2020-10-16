using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class Paciente
    {
        private enumNiveles iNivel;

        public enumNiveles Nivel
        {
            get { return iNivel; }
            set { iNivel = value; }
        }
    }
}
