using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento("Hola, soy un documento .pdf");
            Impresora impresora = new Impresora();

            impresora.Imprimir(doc);

            Console.ReadKey();
        }
    }
}
