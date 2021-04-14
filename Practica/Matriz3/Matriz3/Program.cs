using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz3
{
    class Program
    {
        public int[,] matriz;

        public void Cargar()
        {
            matriz = new int[3, 4];
            string linea;

            for(int f = 0; f < 3; f++)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirPrimerFila()
        {
            Console.Write("Primer fila = ");

            for(int c = 0; c < 4; c++)
            {
                Console.Write(matriz[0, c] + " ");
            }

            Console.WriteLine("");
        }

        public void ImprimirUltimaFila()
        {
            Console.Write("Ultima fila = ");

            for(int c = 0; c < 4; c++)
            {
                Console.Write(matriz[2, c]);
            }

            Console.WriteLine("");
        }

        public void ImprimirPrimerColumna()
        {
            Console.Write("Primer Columna = ");

            for(int f = 0; f < 3; f++)
            {
                Console.Write(matriz[f, 0]);
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.ImprimirPrimerFila();
            obj.ImprimirUltimaFila();
            obj.ImprimirPrimerColumna();

            Console.ReadKey();
        }
    }
}
