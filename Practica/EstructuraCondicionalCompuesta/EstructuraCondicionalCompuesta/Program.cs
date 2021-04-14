using System;

namespace EstructuraCondicionalCompuesta
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("El numero mayor es: ");

            if(num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
