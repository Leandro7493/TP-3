using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fach = new Fachada();

            SalaConsulta salaConsulta = new SalaConsulta();
            SalaUrgencia salaUrgencia = new SalaUrgencia();

            EstrategiaFIFO estrategiaFIFO = new EstrategiaFIFO();
            EstrategiaTriaje estrategiaTriaje = new EstrategiaTriaje();

            salaConsulta = fach.InicializarSala(salaConsulta, estrategiaFIFO);
            salaUrgencia = fach.InicializarSala(salaUrgencia, estrategiaTriaje);


            while (true)
            {
                Paciente iPaciente = new Paciente();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Pacientes Sala Consulta: ");
                foreach(string n in fach.NombresPacientes(salaConsulta))
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Pacientes Sala Urgencia: ");
                foreach (string n in fach.NombresPacientes(salaUrgencia))
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Ingrese la accion a realizar: ");
                Console.WriteLine("1- Agregar nueva consulta: ");
                Console.WriteLine("2- Agregar nuevo paciente de urgencia: ");
                Console.WriteLine("3- Atender sala consulta: ");
                Console.WriteLine("4- Atender sala urgencia: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre: ");
                        iPaciente.Nombre = Console.ReadLine();
                        fach.AgregarPaciente(salaConsulta, iPaciente);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre: ");
                        iPaciente.Nombre = Console.ReadLine();
                        Console.WriteLine("Nivel de urgencia: ");
                        iPaciente.Nivel = (enumNiveles) int.Parse(Console.ReadLine());
                        fach.AgregarPaciente(salaUrgencia, iPaciente);
                        break;
                    case 3:
                        iPaciente = fach.AtenderPaciente(salaConsulta);
                        Console.WriteLine("Paciente:" + iPaciente.Nombre + " atendido");
                        break;
                    case 4:
                        iPaciente = fach.AtenderPaciente(salaUrgencia);
                        Console.WriteLine("Paciente:" + iPaciente.Nombre + " atendido");
                        break;
                    default:
                        Console.WriteLine("Numero no valido");
                        continue;
                }
            }
        }
    }
}
