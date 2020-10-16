using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaFIFO : iEstrategiaAsignacion
    {
        public void OrdenarPaciente(Paciente pPaciente, Paciente[] pPacientes)
        {
            for (int i = 0; i < pPacientes.Length; i++)
            {
                if (pPacientes[i] == null)
                {
                    pPacientes[i] = pPaciente;
                }
            }
        }
    }
}
