using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número entero que represente el valor del atributo LADO: ");
            string entrada = Console.ReadLine();

            Cubo miCubo = new Cubo(entrada); // instanciamos un objeto de la clase Cubo

            //miCubo.Lado = 5;

            miCubo.CalcularArea();
            miCubo.CalcularVolumen();

            Console.WriteLine($"Área = {miCubo.Area}, Volumen = {miCubo.Volumen}");

            Console.ReadKey();
        }
    }
}
