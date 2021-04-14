using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Confeccionar un método que reciba un entero 
        entre 1 y 10 y retorne el valor en castellano. 
 */

namespace ParametrosValor3
{
    class Program
    {
        public int Cargar()
        {
            string linea;
            int num;

            Console.Write("Ingrese un numero entero entre 1 y 10: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            return num;
        }

        public string ValorEnCastellano(int num)
        {
            string valor;

            switch(num)
            {
                case 1:
                    valor = "uno";
                    break;
                case 2:
                    valor = "dos";
                    break;
                case 3:
                    valor = "tres";
                    break;
                case 4:
                    valor = "cuatro";
                    break;
                case 5:
                    valor = "cinco";
                    break;
                case 6:
                    valor = "seis";
                    break;
                case 7:
                    valor = "siete";
                    break;
                case 8:
                    valor = "ocho";
                    break;
                case 9:
                    valor = "nueve";
                    break;
                case 10:
                    valor = "diez";
                    break;

                default:
                    valor = "Fuera de rango";
                    break;
            }

            return valor;
        }

        static void Main(string[] args)
        {
            int numero;

            Program obj = new Program();

            numero = obj.Cargar();
            Console.Write(obj.ValorEnCastellano(numero));

            Console.ReadKey();
        }
    }
}
