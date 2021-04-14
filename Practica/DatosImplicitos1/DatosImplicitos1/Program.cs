using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Confeccionar un programa que defina variables con 
        tipo de dato implícitos para almacenar un entero, 
        un real, un caracter y un valor lógico. Imprimir sus valores. 
 */

namespace DatosImplicitos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var edad = 44;
            var distancia = 7.55;
            var continua = true;
            var tecla = 'A';
            Console.WriteLine(edad);
            Console.WriteLine(distancia);
            Console.WriteLine(continua);
            Console.WriteLine(tecla);
            Console.ReadKey();
        }
    }
}
