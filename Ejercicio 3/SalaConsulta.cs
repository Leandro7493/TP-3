using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class SalaConsulta : Sala
    {
        private EstrategiaFIFO Estrategia { get; set; }
        public override void RecibirPaciente(Paciente pPaciente)
        {
            Estrategia.OrdenarPaciente(pPaciente, iPacientes);
        }
    }
}
