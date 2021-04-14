using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, resta, multiplicacion, division;
            string linea;

            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if(num1 > num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;

                Console.Write("La suma de los numeros es: ");
                Console.WriteLine(suma);

                Console.Write("Y la resta es: ");
                Console.WriteLine(resta);
            }
            else
            {
                multiplicacion = num1 * num2;
                division = num1 / num2;

                Console.Write("La multiplicacion de los numeros es: ");
                Console.WriteLine(multiplicacion);

                Console.Write("Y la division es: ");
                Console.WriteLine(division);
            }

            Console.ReadKey();
        }
    }
}
