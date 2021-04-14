using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema
        Confeccionar una clase que administre
        un vector con 5 elementos enteros.
        Definir un método que recorra el vector
        y llame a una expresión lambda que pueda
        analizar cada elemento del vector.

        Llamar al método que recorre el vector y
        resolver mediante lambdas los siguientes
        algoritmos:

        La cantidad de múltiplos de 3
        La suma de todas las componentes superiores
        a 50 
 */

namespace Lambda4
{
    public delegate void Retorna(int elemento);

    public class Vector
    {
        private int[] vec = { 10, 23, 200, 12, 75 };

        public void Imprimir()
        {
            Console.WriteLine("Listado completo del vector.");
            foreach (var elemento in vec)
                Console.Write("{0}-", elemento);
            Console.WriteLine();
        }

        public void Recorrer(Retorna retorna)
        {
            foreach (var elemento in vec)
                retorna(elemento);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Imprimir();
            var multiplos3 = 0;
            v.Recorrer(elemento => {
                if (elemento % 3 == 0)
                    multiplos3++;
            });
            Console.WriteLine("Cantidad de elementos múltiplos de 3: {0}", multiplos3);
            var suma = 0;
            v.Recorrer(elemento => {
                if (elemento > 50)
                    suma += elemento;
            });
            Console.WriteLine("La suma de todas las componentes superiores a 50: {0}", suma);
            Console.ReadKey();
        }
    }
}
