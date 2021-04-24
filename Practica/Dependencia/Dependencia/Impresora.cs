using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    class Impresora 
    {
        public void Imprimir(Documento doc) // dependencia
        {
            Console.WriteLine(doc.Texto);
        }

    }
}
