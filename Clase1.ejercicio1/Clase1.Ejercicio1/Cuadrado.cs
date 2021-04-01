using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Cuadrado : Figuras
    {
        public int Area()
        {
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            int lado = int.Parse(Console.ReadLine());

            return lado *= 4;

        }

        public int Perimetro()
        {
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            int lado = int.Parse(Console.ReadLine());

            return lado *= lado;

        }
    }
}
