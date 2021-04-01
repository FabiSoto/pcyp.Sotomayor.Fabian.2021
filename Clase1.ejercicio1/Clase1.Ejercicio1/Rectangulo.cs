using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Rectangulo: Figuras

    {
        public int Area()
        {
            Console.WriteLine("Ingrese la base del rectangulo: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            int altura = int.Parse(Console.ReadLine());

            return base1 *= altura;

            
        }

        public int Perimetro()
        {
            Console.WriteLine("Ingrese la base del rectangulo: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo:  ");
            int altura = int.Parse(Console.ReadLine());

            return base1 = (base1*2) + (altura*2 );

        }

    }
}
