using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz1
{
    class Program
    {
        public int[,] matriz;

        public void Cargar()
        {
            matriz = new int[3, 5];
            string linea;

            for(int f = 0; f < 3; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.Imprimir();
            Console.ReadKey();
        }
    }
}
