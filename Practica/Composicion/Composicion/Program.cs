using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa1 = new Mesa(4);

            Console.WriteLine("La mesa tiene " + mesa1.Patas.Count + " patas.");

            mesa1.Patas.ForEach(pata =>
            {
                Console.WriteLine(pata.color);
            });

            /*foreach(Pata p in mesa1.Patas)
            {
                Console.WriteLine(p.color);
            }*/

            Console.ReadKey();
        }
    }
}
