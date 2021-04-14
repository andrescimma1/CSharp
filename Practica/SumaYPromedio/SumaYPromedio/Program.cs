using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaYPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, promedio;
            string linea;

            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el valor del tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese el valor del cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.Write("La suma de los cuatro numeros es: ");
            Console.WriteLine(suma);

            Console.Write("Y el promedio es: ");
            Console.WriteLine(promedio);

            Console.ReadKey();
        }
    }
}
