using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Plantear una clase que sobrecargue un método 
        que permita cargar por referencia (out) distintos
        tipos de datos primitivos por teclado. 
 */

namespace SobrecargaParametros3
{
    class EntradaTeclado
    {
        public void Leer(out int valor)
        {
            valor = int.Parse(Console.ReadLine());
        }

        public void Leer(out float valor)
        {
            valor = float.Parse(Console.ReadLine());
        }

        public void Leer(out char valor)
        {
            valor = char.Parse(Console.ReadLine());
        }

        public void Leer(out bool valor)
        {
            valor = bool.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            EntradaTeclado et = new EntradaTeclado();
            int x;
            Console.Write("Ingrese un entero:");
            et.Leer(out x);
            Console.WriteLine("El valor ingresado es:" + x);
            float f;
            Console.Write("Ingrese un valor real:");
            et.Leer(out f);
            Console.WriteLine("El valor ingresado es:" + f);
            char car;
            Console.Write("Ingrese un valor caracter:");
            et.Leer(out car);
            Console.WriteLine("El valor ingresado es:" + car);
            bool l;
            Console.Write("Ingrese un valor logico:");
            et.Leer(out l);
            Console.WriteLine("El valor ingresado es:" + l);
            Console.ReadKey();
        }
    }
}
