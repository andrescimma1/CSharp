using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMayorDe3Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("El numero mayor es: ");

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }

            Console.ReadKey();
        }
    }
}
