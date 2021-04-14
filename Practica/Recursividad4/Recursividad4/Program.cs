using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problema 4:
        Imprimir los números de 1 a 5 en 
        pantalla utilizando recursividad.
*/

namespace Recursividad4
{
    class Recursividad
    {
        void Imprimir(int x)
        {
            if(x < 6)
            {
                Console.Write(x);
                Imprimir(x + 1);
            }
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();

            re.Imprimir(1);
            Console.ReadKey();
        }
    }
}
