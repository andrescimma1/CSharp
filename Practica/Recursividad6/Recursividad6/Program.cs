using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problema 6:
      Implementar un método recursivo para ordenar los
       elementos de un vector.
 */

namespace Recursividad6
{
    class Recursivdad
    {
        int[] vec = { 312, 614, 88, 22, 54 };

        void Ordenar(int[] v, int cant)
        {
            if (cant > 1)
            {
                for (int f = 0; f < cant - 1; f++)
                {
                    if (v[f] > v[f + 1])
                    {
                        int aux = v[f];
                        v[f] = v[f + 1];
                        v[f + 1] = aux;
                    }
                }
                Ordenar(v, cant - 1);
            }
        }

        void Procesar()
        {
            Ordenar(vec, vec.Length);
        }

        void Imprimir()
        {
            for (int f = 0; f < vec.Length; f++)
                Console.WriteLine(vec[f] + "  ");
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            Recursivdad r = new Recursivdad();
            r.Imprimir();
            r.Procesar();
            r.Imprimir();
            Console.ReadKey();
        }
    }
}
