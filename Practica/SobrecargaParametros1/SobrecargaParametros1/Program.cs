using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar dos métodos que sumen dos enteros 
        en el primer caso y que concatenen dos string 
        en el segundo. 
 */

namespace SobrecargaParametros1
{
    class Program
    {
        public int Sumar(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        public string Sumar(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("La suma de 5+10 es:" + p.Sumar(5, 10));
            Console.WriteLine("La concatenacion de \"Juan\" y \" Carlos\" es " + p.Sumar("Juan", " Carlos"));
            Console.ReadKey();
        }
    }
}
