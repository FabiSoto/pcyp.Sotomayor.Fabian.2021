using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Triangulo : Figuras
    {
        public int Area()
        {
            Console.WriteLine("Ingrese el base del triangulo: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            int altura = int.Parse(Console.ReadLine());

            return base1 = (base1 * altura) / 2;

        }

        public int Perimetro()
        {
            Console.WriteLine("Ingrese el lado del triangulo: ");
            int lado = int.Parse(Console.ReadLine());

            return lado = lado + lado + lado;
        }
    }
}
