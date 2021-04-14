using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Confeccionar un método que me retorne dos
        valores aleatorios comprendidos entre 1 y 
        100 mediante parámetros por referencia. 
 */

namespace ParametrosReferencia4
{
    class Program
    {
        public void Aleatorios(out int num1, out int num2)
        {
            Random r = new Random();

            num1 = r.Next(1, 101);
            num2 = r.Next(1, 101);
        }

        static void Main(string[] args)
        {
            int v1, v2;

            Program obj = new Program();

            obj.Aleatorios(out v1, out v2);


            Console.WriteLine("Primer numero aleatorio: " + v1);
            Console.WriteLine("Segundo numero aleatorio: " + v2);

            Console.ReadLine();
        }
    }
}
