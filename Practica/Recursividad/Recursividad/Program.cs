using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problema 1:
        Implementación de un método recursivo. */

namespace Recursividad
{
    public class Recursividad
    {

        void Repetir()
        {
            Repetir();
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Repetir();
        }

    }
}
