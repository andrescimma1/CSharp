using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaCola1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila1 = new Stack<int>();
            Console.WriteLine("Insertamos tres elementos en la pila:10, 25 y 70");
            pila1.Push(10);
            pila1.Push(25);
            pila1.Push(70);
            Console.WriteLine("Cantidad de elementos en la pila:" + pila1.Count);
            Console.WriteLine("Extraemos un elemento de la pila:" + pila1.Pop());
            Console.WriteLine("Cantidad de elementos en la pila:" + pila1.Count);

            Queue<string> cola1 = new Queue<string>();
            Console.WriteLine("Insertamos tres elementos en la cola:'ana', 'juan' y 'pedro'");
            cola1.Enqueue("ana");
            cola1.Enqueue("juan");
            cola1.Enqueue("pedro");
            Console.WriteLine("Cantidad de elementos en la cola:" + cola1.Count);
            Console.WriteLine("Extraemos un elemento de la cola:" + cola1.Dequeue());
            Console.WriteLine("Cantidad de elementos en la cola:" + cola1.Count);
            Console.ReadKey();
        }
    }
}
