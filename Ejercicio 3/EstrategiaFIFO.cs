using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaFIFO : iEstrategiaAsignacion
    {
        public List<Paciente> OrdenarPaciente(Paciente pPaciente, List<Paciente> pPacientes)
        {
            pPacientes.Add(pPaciente);
            return pPacientes;
        }

    }
}
