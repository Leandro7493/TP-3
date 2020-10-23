using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class SalaUrgencia : Sala
    {
        private EstrategiaTriaje Estrategia { get; set; }
        public override void RecibirPaciente(Paciente pPaciente)
        {
            Estrategia.OrdenarPaciente(pPaciente, iPacientes);
        }
    }
}
