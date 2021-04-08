using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan","55423412");
            values.Add("Hernesto","56985623");
            values.Add("Mariana","54787451");

            if(values.ContainsKey("Juan") == true)
            {
                Console.WriteLine(values["Juan"]);
            }


            string value;

            if(values.TryGetValue("Pedro", out value))
            {
                Console.WriteLine("For key = \"Pedro\", value = {0} ",value);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            foreach (KeyValuePair<string, string> item in values)
            {
                Console.WriteLine("{0} , {1}", item.Key, item.Value);
            }

            values.Remove("Mariana");
            values.Add("Mariana", "58251425");

            foreach (KeyValuePair<string, string> item in values)
            {
                if (item.Key == "Mariana")
                {
                    Console.WriteLine("{0},  Nuevo telefono de Mariana = {1}", item.Key, item.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
