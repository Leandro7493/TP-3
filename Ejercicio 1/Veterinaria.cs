using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Veterinaria
    {
        public void AceptarAnimales (Animal[] animales)
        {
            foreach (var animal in animales) 
            {
                animal.HacerRuido();
            }
        }
    }
}
