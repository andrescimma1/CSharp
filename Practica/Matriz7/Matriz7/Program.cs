using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz7
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

        public void Mostrar()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }

                Console.WriteLine();
            }
        }

        public void IntercambiarFilas()
        {
            int aux;

            Mostrar();

            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }

            Console.WriteLine();
            Mostrar();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.IntercambiarFilas();

            Console.ReadKey();
        }
    }
}
