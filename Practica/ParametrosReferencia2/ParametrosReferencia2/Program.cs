using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto
        Confeccionar un método que reciba por referencia
        tres enteros y nos los retorne en forma ordenada 
        de menor a mayor. 
 */

namespace ParametrosReferencia2
{
    class Program
    {
        public void Ordenados(ref int v1, ref int v2, ref int v3)
        {
            int menor;
            int intermedio;
            int mayor;
            if (v1 <= v2 & v1 <= v3)
            {
                menor = v1;
                if (v2 < v3)
                {
                    intermedio = v2;
                    mayor = v3;
                }
                else
                {
                    intermedio = v3;
                    mayor = v2;
                }
            }
            else
            {
                if (v2 <= v3)
                {
                    menor = v2;
                    if (v1 < v3)
                    {
                        intermedio = v1;
                        mayor = v3;
                    }
                    else
                    {
                        intermedio = v3;
                        mayor = v1;
                    }
                }
                else
                {
                    menor = v3;
                    if (v1 < v2)
                    {
                        intermedio = v1;
                        mayor = v2;
                    }
                    else
                    {
                        intermedio = v2;
                        mayor = v1;
                    }
                }
            }
            v1 = menor;
            v2 = intermedio;
            v3 = mayor;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Ingrese primer valor:");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese primer valor:");
            int x3 = int.Parse(Console.ReadLine());
            p.Ordenados(ref x1, ref x2, ref x3);
            Console.WriteLine("Los valores ordenados de menor a mayor:");
            Console.WriteLine(x1 + " " + x2 + " " + x3);
            Console.ReadKey();
        }
    }
}
