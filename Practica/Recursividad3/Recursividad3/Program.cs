using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problema 3:
        Implementar un método recursivo que imprima en forma 
        descendente de 5 a 1 de uno en uno.
*/

namespace Recursividad3
{
    public class Recursividad
    {
        void Imprimir(int x)
        {
            if(x > 0)
            {
                Console.Write(x);
                Imprimir(x - 1);
            }
        }


        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);

            Console.ReadKey();
        }
    }
}
