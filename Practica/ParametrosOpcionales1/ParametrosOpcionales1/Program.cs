using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar un método que muestre un 
        mensaje en la pantalla con dos parámetros 
        opcionales que indiquen la columna y la fila 
        donde imprimir. 
 */

namespace ParametrosOpcionales1
{
    class Program
    {
        public void Imprimir(string mensaje, int col = 1, int fil = 1)
        {
            Console.SetCursorPosition(col, fil);
            Console.Write(mensaje);
        }
        static void Main(string[] args)
        {
            Program ob1 = new Program();
            ob1.Imprimir("Hola");
            ob1.Imprimir("Hola", 40);
            ob1.Imprimir("Hola", 40, 12);
            Console.ReadKey();
        }
    }
}
