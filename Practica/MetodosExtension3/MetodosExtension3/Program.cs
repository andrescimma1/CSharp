using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema
        Agregar un método de extensión a la clase
        int que permita imprimir desde el valor 
        actual que tiene la variable entera hasta
        el valor que le pasemos como parámetro, de
        uno en uno. 
 */

namespace MetodosExtension3
{
    public static class Extension
    {
        public static void ImprimirHasta(this int valor, int fin)
        {
            for (var inicio = valor; inicio <= fin; inicio++)
                Console.Write("{0} ", inicio);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            10.ImprimirHasta(30);
            Console.WriteLine();
            int va = 100;
            va.ImprimirHasta(150);
            Console.ReadKey();
        }
    }
}
