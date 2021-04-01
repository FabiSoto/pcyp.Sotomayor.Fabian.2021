using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            Triangulo triangulo1 = new Triangulo();
            Cuadrado cuadrado1 = new Cuadrado();
            ConsoleKeyInfo op;

            do
            {
                Console.Clear();
                Console.Write("[A] Rectangulo\n");
                Console.Write("[B] Triangulo\n");
                Console.Write("[C] Cuadrado\n");
                Console.Write("[Esc] Salir\n");
                Console.WriteLine("Seleccione un opcion: ");
                op = Console.ReadKey(true);


                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine(rectangulo1.Area());
                        Console.WriteLine(rectangulo1.Perimetro());
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine(triangulo1.Area());
                        Console.WriteLine(triangulo1.Perimetro());
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine(cuadrado1.Area());
                        Console.WriteLine(cuadrado1.Perimetro());
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:

                        Console.WriteLine("Fin del programa");
                        break;
                }

            } while (op.Key != ConsoleKey.Escape);



            

        }
    }
}
