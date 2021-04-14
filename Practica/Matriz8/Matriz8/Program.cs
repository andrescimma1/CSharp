using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz8
{
    class Program
    {
        public int[,] matriz;
        public void Cargar()
        {
            int filas, columnas;
            string linea;

            Console.Write("Ingrese la cantidad de filas: ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);

            Console.Write("Ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);

            matriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Vertices()
        {
            Console.WriteLine(matriz[0, 0] + " " +
                              matriz[0, matriz.GetLength(1) - 1] + " ");

            Console.Write(matriz[matriz.GetLength(0) - 1, 0] + " " +
                          matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1]
                          );
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.Vertices();

            Console.ReadKey();
        }
    }
}
