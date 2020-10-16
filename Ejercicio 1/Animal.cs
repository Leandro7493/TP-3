using System;

namespace Ejercicio_1
{
    public abstract class Animal
    {
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }

        public abstract void HacerRuido();
    }
}
