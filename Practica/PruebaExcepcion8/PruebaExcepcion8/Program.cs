using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Implementar la clase Operaciones. Debe 
        tener dos propiedades de tipo int. 
        Desarrollar los métodos para calcular su
        suma, resta, multiplicación y división, 
        imprimir dichos resultados. Lanzar una 
        excepción en el método que calcula la 
        división si el segundo valor es cero. 
 */

namespace PruebaExcepcion8
{
    class Operaciones
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public Operaciones(int valor1, int valor2)
        {
            Num1 = valor1;
            Num2 = valor2;
        }

        public void Sumar()
        {
            int suma = Num1 + Num2;
            Console.WriteLine($"La suma es: {suma}");
        }

        public void Restar()
        {
            int resta = Num1 - Num2;
            Console.WriteLine($"La resta es: {resta}");
        }

        public void Multiplicar()
        {
            int multiplicacion = Num1 * Num2;
            Console.WriteLine($"La multiplicación es: {multiplicacion}");
        }

        public void Dividir()
        {
            if(Num2 == 0)
            {
                throw new Exception("No se puede dividir por cero.");
            }

            int division = Num1 / Num2;
            Console.WriteLine($"La división es: {division}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones(10, 0);
            op.Sumar();
            op.Restar();
            op.Multiplicar();
            try
            {
                op.Dividir();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
