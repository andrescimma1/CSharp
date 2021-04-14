using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz2
{
    class Program
    {
        public int[,] matriz;

        public void Cargar()
        {
            matriz = new int[4, 4];
            string linea;

            for(int f = 0; f < 4; f++)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirEnDiagonal()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.ImprimirEnDiagonal();
        }
    }
}
