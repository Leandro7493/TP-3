using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class SalaConsulta : Sala
    {
        public EstrategiaFIFO Estrategia { get; set; }
        public override void RecibirPaciente(Paciente pPaciente)
        {
            iPacientes = Estrategia.OrdenarPaciente(pPaciente, iPacientes);
        }
    }
}
