using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public abstract class Sala
    {
        private Paciente[] iPacientes;

        public Sala()
        {
            iPacientes = new Paciente[10];
        }

        public abstract void RecibirPaciente(Paciente pPaciente);
    }
}
