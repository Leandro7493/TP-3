using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public interface iEstrategiaAsignacion
    {
        public abstract void OrdenarPaciente(Paciente pPaciente, Paciente[] pPacientes);
    }
}
