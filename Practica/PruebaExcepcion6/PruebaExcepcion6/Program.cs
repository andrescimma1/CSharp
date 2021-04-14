using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*
    Problema:
        Crear un archivo de texto con dos líneas.
        Luego proceder a leer el contenido del archivo
        de texto y mostrarlo por pantalla. Asegurarse 
        de liberar el archivo luego de trabajar con el 
        mismo.
 */

namespace PruebaExcepcion6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter txt = null;
            try
            {
                txt = new StreamWriter("datos.txt");
                txt.WriteLine("Línea 1");
                txt.WriteLine("Línea 2");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (txt != null)
                    txt.Close();
            }

            StreamReader txtleer = null;
            try
            {
                txtleer = new StreamReader("datos.txt");
                string linea = txtleer.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = txtleer.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (txtleer != null)
                    txtleer.Close();
            }
            Console.ReadKey();
        }
    }
}
