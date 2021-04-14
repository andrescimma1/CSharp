using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatosPrimitivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo byte:" + v1);
            sbyte v2 = -100;
            Console.WriteLine("Valor almacenado en la variable de tipo sbyte:" + v2);
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en la variable de tipo short:" + v3);
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en la variable de tipo ushort:" + v4);
            int v5 = -2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo int:" + v5);
            uint v6 = 2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo uint:" + v6);
            long v7 = -1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo long:" + v7);
            ulong v8 = 1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ulong:" + v8);
            Console.ReadKey();
        }
    }
}
