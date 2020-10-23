using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class EstrategiaTriaje : iEstrategiaAsignacion
    {
        public void OrdenarPaciente(Paciente pPaciente, List<Paciente> pPacientes)
        {
            if (pPacientes.Count == 0)
            {
                pPacientes.Add(pPaciente);
            }
            else
            {
                for (int i = 0; i < pPacientes.Count; i++)
                {
                    if (pPacientes[i] == null)
                    {
                        pPacientes[i] = pPaciente;
                        break;
                    }
                    else if (pPacientes[i].Nivel > pPaciente.Nivel)
                    {
                        MoverPaciente(pPacientes, pPaciente, i);
                    }
                }
            }
        }

        private void MoverPaciente(List<Paciente> pPacientes, Paciente pPaciente, int posicion)
        {
            for (int i = posicion; i < pPacientes.Count - 1; i++)
            {
                var aux = pPacientes[i];
                pPacientes[i] = pPaciente;
                pPacientes[i + 1] = aux;
            }
        }

        public void EliminarPaciente(List<Paciente> pPacientes)
        {
            pPacientes.RemoveAt(0);
        }
    }
}
