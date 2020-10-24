using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Ejercicio_3
{
    class Fachada
    {     
        public void AgregarPaciente(Sala pSala, Paciente pPaciente)
        {
            pSala.RecibirPaciente(pPaciente);
        }
        public Paciente AtenderPaciente(SalaConsulta pSala)
        {
            return pSala.EliminarPaciente(pSala.iPacientes);
        }

        public Paciente AtenderPaciente(SalaUrgencia pSala)
        {
            return pSala.EliminarPaciente(pSala.iPacientes);
        }

        public List<string> NombresPacientes(SalaConsulta pSala)
        {
            List<string> tempNombres = new List<string>();
            foreach(Paciente p in pSala.iPacientes)
            {
                tempNombres.Add(p.Nombre);
            }
            return tempNombres;
        }

        public List<string> NombresPacientes(SalaUrgencia pSala)
        {
            List<string> tempNombres = new List<string>();
            foreach (Paciente p in pSala.iPacientes)
            {
                tempNombres.Add(p.Nombre + "  " + p.Nivel);
            }
            return tempNombres;
        }

        public SalaUrgencia InicializarSala(SalaUrgencia pSala, EstrategiaTriaje pEst)
        {
            Random random = new Random();
            pSala.Estrategia = pEst;
            for (int i = 0; i < 10; i++)
            {
                Paciente nuevoPaciente = new Paciente();
                nuevoPaciente.Nombre = "Paciente " + i.ToString();
                int randomNumber = random.Next(1, 5);
                nuevoPaciente.Nivel = (enumNiveles) randomNumber;
                AgregarPaciente(pSala, nuevoPaciente);
            }
            return pSala;
        }
        public SalaConsulta InicializarSala(SalaConsulta pSala, EstrategiaFIFO pEst)
        {
            pSala.Estrategia = pEst;
            for (int i = 0; i < 10; i++)
            {
                Paciente nuevoPaciente = new Paciente();
                nuevoPaciente.Nombre = "Paciente " + i.ToString();
                AgregarPaciente(pSala, nuevoPaciente);
            }
            return pSala;
        }
    }
}
