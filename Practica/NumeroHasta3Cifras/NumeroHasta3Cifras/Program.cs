using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroHasta3Cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.Write("Ingrese un numero positivo de hasta 3 cifras: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if(numero >= 0 && numero < 10)
            {
                Console.Write("El numero tiene 1 digito");
            }
            else if(numero >= 10 && numero < 100)
            {
                Console.Write("El numero tiene 2 digitos");
            }
            else if(numero >= 100 && numero < 1000)
            {
                Console.Write("El numero tiene 3 digitos");
            }
            else if(numero >= 1000)
            {
                Console.Write("ERROR, el numero tiene mas de 3 digitos");
            }

            Console.ReadKey();
        }
    }
}
