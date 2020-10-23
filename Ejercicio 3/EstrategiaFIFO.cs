using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaFIFO : iEstrategiaAsignacion
    {
        public void OrdenarPaciente(Paciente pPaciente, List<Paciente> pPacientes)
        {
            pPacientes.Add(pPaciente);
        }

        public void EliminarPaciente(List<Paciente> pPacientes)
        {
            pPacientes.RemoveAt(0);
        }
    }
}
