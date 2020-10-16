using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaTriaje : iEstrategiaAsignacion
    {
        public void OrdenarPaciente(Paciente pPaciente, Paciente[] pPacientes)
        {
            for (int i = 0; i < pPacientes.Length; i++)
            {
                if(pPacientes[i] == null)
                {
                    pPacientes[i] = pPaciente;
                    break;
                }
                else if(pPacientes[i].Nivel > pPaciente.Nivel)
                {
                    // Agregar nuevo paciente y metodo para
                    // mover los demas pacientes del array
                }
            }
        }
    }
}
