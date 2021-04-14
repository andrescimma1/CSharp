using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 2:
        Confeccionar un método que reciba como parámetros
        tres valores enteros y retorne el mayor de los mismos. 
 */

namespace ParametrosValor2
{
    class Program
    {
        public int Mayor(int v1, int v2, int v3)
        {
            if (v1 >= v2 && v1 >= v3)
            {
                return v1;
            }
            else
            {
                if (v2 >= v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Ingrese primer valor:");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer valor:");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("El mayor valor de los tres es:" + p.Mayor(x1, x2, x3));
            Console.ReadKey();
        }
    }
}
