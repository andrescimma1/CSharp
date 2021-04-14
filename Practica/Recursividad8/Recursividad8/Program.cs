using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Problema 2:
    Recorrer un árbol de directorios en forma recursiva.
*/

namespace Recursividad8
{
    public class Recursividad
    {
        public void Leer(string inicio)
        {
            string[] archivos = Directory.GetFiles(inicio);
            Console.WriteLine(inicio + " (Directorio)");
            for (int f = 0; f < archivos.Length; f++)
            {
                Console.WriteLine(archivos[f] + " (Archivo)");
            }
            string[] directorios = Directory.GetDirectories(inicio);
            for (int f = 0; f < directorios.Length; f++)
            {
                Leer(directorios[f]);
            }
        }

        static void Main(string[] args)
        {
            Recursividad rec = new Recursividad();
            rec.Leer("c:\\Windows\\");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
