using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Confeccionar un método que muestre
        los primeros 10 números pares. En 
        caso que le pasemos un parámetro 
        opcional mostrar tantos pares como
        indica el parámetro. 
 */

namespace ParametrosOpcionales2
{
    class Program
    {
        public void Pares(int numero = 10)
        {
            int par = 2;

            for(int i = 1; i <= numero; i++)
            {
                Console.Write(par + "-");
                par += 2;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Pares();
            obj.Pares(5);
            obj.Pares(7);
            obj.Pares(12);

            Console.ReadKey();
        }
    }
}
