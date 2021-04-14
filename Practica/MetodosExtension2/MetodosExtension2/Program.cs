using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema
        Agregar un método de extensión a la clase
        List que permita imprimir todos los elementos
        de la lista. El método de extensión debe ser 
        genérico. 
 */

namespace MetodosExtension2
{
    public static class Extension
    {
        public static void Imprimir<T>(this List<T> lista)
        {
            foreach (var elemento in lista)
                Console.Write("{0} ", elemento);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            lista1.Add(10);
            lista1.Add(20);
            lista1.Add(30);
            lista1.Add(500);
            lista1.Add(400);
            lista1.Imprimir();
            Console.ReadKey();
        }
    }
}
