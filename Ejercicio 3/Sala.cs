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

        public virtual Paciente EliminarPaciente(List<Paciente> pPacientes)
        {
            Paciente iTempPaciente = pPacientes[0];
            pPacientes.RemoveAt(0);
            return iTempPaciente;
        }
    }
}
