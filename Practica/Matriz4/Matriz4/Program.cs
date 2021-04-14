using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz4
{
    class Program
    {
        public int[,] matriz;

        public void CargarPorColumna()
        {
            matriz = new int[2, 5];
            string linea;

            for(int c = 0; c < 5; c++)
            {
                for(int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for(int f = 0; f < 2; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.CargarPorColumna();
            obj.Imprimir();

            Console.ReadKey();
        }
    }
}
