using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar un método que reciba dos enteros 
        y luego imprima de uno en uno desde el valor 
        menor hasta el valor mayor.
 */

namespace ParametrosValor1
{
    class Program
    {
        public void MostrarRango(int menor, int mayor)
        {
            for (var x = menor; x <= mayor; x++)
            {
                Console.Write(x + " ");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrarRango(1, 25);
            Console.ReadKey();
        }
    }
}
