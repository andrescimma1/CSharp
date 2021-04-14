using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            string linea;

            Console.Write("Ingrese sueldo: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);

            if(sueldo > 3000)
            {
                Console.Write("Debe abonar impuestos!");
            }

            Console.ReadKey();
        }
    }
}
