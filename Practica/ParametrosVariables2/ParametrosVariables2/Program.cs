using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Confeccionar un método que reciba un 
        string con la cadena "suma" o "producto"
        y seguidamente una lista de enteros. 
        El método debe retornar la suma o producto
        de todos los valores enviados.
 */

namespace ParametrosVariables2
{
    class Program
    {
        public int Operar(string respuesta, params int [] p)
        {
            if(respuesta == "suma")
            {
                int suma = 0;

                for(int i = 0; i < p.Length; i++)
                {
                    suma += p[i];
                }

                return suma;
            }

            if(respuesta == "producto")
            {
                int producto = 1;

                for(int i = 0; i < p.Length; i++)
                {
                    producto *= p[i];
                }

                return producto;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.Write("La suma de 2+1+9 es: ");
            Console.WriteLine(obj.Operar("suma", 2, 1, 9));
            Console.Write("El producto de 2*9*7 es: ");
            Console.WriteLine(obj.Operar("producto", 2, 9, 7));

            Console.ReadKey();
        }
    }
}
