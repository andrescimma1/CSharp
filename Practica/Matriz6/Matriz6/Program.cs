using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz6
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
                for(int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirMayorElemento()
        {
            int mayor = 0, fila = 0, columna = 0;

            for(int f = 0; f < matriz.GetLength(0); f++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    if(matriz[f,c] > mayor)
                    {
                        mayor = matriz[f, c];
                        fila = f;
                        columna = c;
                    }
                }
            }

            Console.WriteLine("El mayor elemento de la matriz es: " + mayor);
            Console.WriteLine("y su ubicacion es en la fila: " + fila + " y la columna: " + columna);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Cargar();
            obj.ImprimirMayorElemento();

            Console.ReadKey();
        }
    }
}
