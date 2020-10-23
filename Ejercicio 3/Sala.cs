using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public abstract class Sala
    {
        public List<Paciente> iPacientes;

        public Sala()
        {
            iPacientes = new List<Paciente>();
        }
        public abstract void RecibirPaciente(Paciente pPaciente);
    }
}
