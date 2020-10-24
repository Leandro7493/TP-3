using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaTriaje : iEstrategiaAsignacion
    {
        public List<Paciente> OrdenarPaciente(Paciente pPaciente, List<Paciente> pPacientes)
        {
            pPacientes.Add(pPaciente);
            List<Paciente> tempPacientes = pPacientes.OrderBy(x => x.Nivel).ToList();
            return tempPacientes;
        }
    }
}
