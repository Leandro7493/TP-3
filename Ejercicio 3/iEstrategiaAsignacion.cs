﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public interface iEstrategiaAsignacion
    {
        public abstract List<Paciente> OrdenarPaciente(Paciente pPaciente, List<Paciente> pPacientes);
    }
}
