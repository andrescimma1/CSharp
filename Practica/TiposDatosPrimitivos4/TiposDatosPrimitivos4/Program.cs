using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 4:
        Mostrar cuantos bytes de memoria requieren cada tipo
        de dato primitivo en C# (utilizar el operador sizeof) 
 */

namespace TiposDatosPrimitivos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bytes reservados para el tipo byte:" + sizeof(byte));
            Console.WriteLine("Bytes reservados para el tipo sbyte:" + sizeof(sbyte));
            Console.WriteLine("Bytes reservados para el tipo short:" + sizeof(short));
            Console.WriteLine("Bytes reservados para el tipo ushort:" + sizeof(ushort));
            Console.WriteLine("Bytes reservados para el tipo int:" + sizeof(int));
            Console.WriteLine("Bytes reservados para el tipo uint:" + sizeof(uint));
            Console.WriteLine("Bytes reservados para el tipo long:" + sizeof(long));
            Console.WriteLine("Bytes reservados para el tipo ulong:" + sizeof(ulong));
            Console.WriteLine("Bytes reservados para el tipo float:" + sizeof(float));
            Console.WriteLine("Bytes reservados para el tipo double:" + sizeof(double));
            Console.WriteLine("Bytes reservados para el tipo decimal:" + sizeof(decimal));
            Console.WriteLine("Bytes reservados para el tipo char:" + sizeof(char));
            Console.WriteLine("Bytes reservados para el tipo bool:" + sizeof(bool));
            Console.ReadKey();
        }
    }
}
