using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar un programa que permita crear, cargar
        y obtener el menor y mayor valor de un vector. La 
        obtención del mayor y menor hacerlo en un único método
        que retorne dichos dos valores.

 */

namespace ParametrosReferencia3
{
    class Program
    {
        private int[] vec;

        public Program()
        {
            Console.Write("Tamaño del vector:");
            int tam = int.Parse(Console.ReadLine());
            vec = new int[tam];
        }

        public void Cargar()
        {
            for (var f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese elemento:");
                vec[f] = int.Parse(Console.ReadLine());
            }
        }

        public void MayorMenor(out int may, out int men)
        {
            may = vec[0];
            men = vec[0];
            for (var f = 1; f < vec.Length; f++)
            {
                if (vec[f] > may)
                {
                    may = vec[f];
                }
                else
                {
                    if (vec[f] < men)
                    {
                        men = vec[f];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            int ma, me;
            p.MayorMenor(out ma, out me);
            Console.WriteLine("El mayor elemento del vector es:" + ma);
            Console.WriteLine("El menor elemento del vector es:" + me);
            Console.ReadKey();
        }
    }
}
