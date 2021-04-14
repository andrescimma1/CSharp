using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoODosDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.Write("Ingrese un numero positivo de uno o dos digitos (1.. 99): ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if(numero < 10)
            {
                Console.Write("El numero tiene 1 digito");
            }
            else
            {
                Console.Write("El numero tiene 2 digitos");
            }

            Console.ReadKey();
        }
    }
}
