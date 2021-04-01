using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase1.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas =  File.ReadAllLines("./File/vial.csv");

            Archivo archivo1 = new Archivo();

            archivo1.imprimir(lineas);
          
        }
    }
}
