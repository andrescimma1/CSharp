using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número en castellano entre uno y cinco:");
            string nro = Console.ReadLine();
            switch (nro)
            {
                case "uno":
                    Console.Write(1);
                    break;
                case "dos":
                    Console.Write(2);
                    break;
                case "tres":
                    Console.Write(3);
                    break;
                case "cuatro":
                    Console.Write(4);
                    break;
                case "cinco":
                    Console.Write(5);
                    break;
                default:
                    Console.Write("Debe ingresar un valor entre uno y cinco");
                    break;
            }
            Console.ReadKey();
        }
    }
}
