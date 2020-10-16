using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();
            Gato gato = new Gato();
            Perro perro = new Perro();
            Animal[] animales = new Animal[2];

            animales[0] = gato;
            animales[1] = perro;

            veterinaria.AceptarAnimales(animales);
            Console.Read();
        }
    }
}
