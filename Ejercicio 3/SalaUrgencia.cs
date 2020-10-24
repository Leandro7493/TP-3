using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Ejercicio_3
{
    class SalaUrgencia : Sala
    {
        public EstrategiaTriaje Estrategia { get; set; }
        public override void RecibirPaciente(Paciente pPaciente)
        {
            iPacientes = Estrategia.OrdenarPaciente(pPaciente, iPacientes);
        }
    }
}
