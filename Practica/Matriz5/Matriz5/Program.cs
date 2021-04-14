using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz5
{
    class Program
    {
        public int[,] matriz;
        int ultimaFila;

        public void Cargar()
        {
            int filas, columnas;
            string linea;

            Console.Write("Ingrese el numero de filas: ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);

            Console.Write("Ingrese el numero de columnas: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);

            matriz = new int[filas, columnas];

            for(int f = 0; f < filas; f++)
            {
                for(int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for(int f = 0; f < matriz.GetLength(0); f++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }

                Console.WriteLine();
            }
        }

        public void BuscarUltimaFila()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                ultimaFila = f;
            }
        }

        public void ImprimirUltimaFila()
        {
            BuscarUltimaFila();

            Console.Write("Ultima fila: ");

            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write(matriz[ultimaFila, c] + " ");
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.Imprimir();
            obj.ImprimirUltimaFila();

            Console.ReadKey();
        }
    }
}
