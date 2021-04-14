using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinGenericos
{
    class PilaEnteros
    {
        private int[] vec = new int[5];
        private int tope = 0;

        public void Insertar(int x)
        {
            vec[tope] = x;
            tope++;
        }

        public int Extraer()
        {
            tope--;
            return vec[tope];
        }
    }

    class PilaString
    {
        private string[] vec = new string[5];
        private int tope = 0;

        public void Insertar(string x)
        {
            vec[tope] = x;
            tope++;
        }

        public string Extraer()
        {
            tope--;
            return vec[tope];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PilaEnteros pila1 = new PilaEnteros();
            pila1.Insertar(20);
            pila1.Insertar(40);
            pila1.Insertar(17);
            Console.WriteLine(pila1.Extraer());

            PilaString pila2 = new PilaString();
            pila2.Insertar("juan");
            pila2.Insertar("ana");
            pila2.Insertar("luis");
            Console.WriteLine(pila2.Extraer());

            Console.ReadKey();
        }
    }
}
