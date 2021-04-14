using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Definir una clase estática llamada Operaciones.
        Implementar cuatro métodos que permitan sumar,
        restar,multiplicar y dividir dos enteros.: 
 */

namespace ClaseEstatica1
{
    static class Operaciones
    {
        public static int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public static int Restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public static int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public static int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10+5 es " + Operaciones.Sumar(10, 5));
            Console.WriteLine("10-5 es " + Operaciones.Restar(10, 5));
            Console.WriteLine("10*5 es " + Operaciones.Multiplicar(10, 5));
            Console.WriteLine("10/5 es " + Operaciones.Dividir(10, 5));
            Console.ReadKey();
        }
    }
}
