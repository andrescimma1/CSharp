using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema
        Plantear un método estático que reciba un
        string y retorne otro. Mediante una 
        expresión lambda analizar cada caracter del
        string original y verificar si lo debe 
        agregar al string de retorno.
        El método debe llamarse Filtrar y luego 
        debemos acceder al mismo desde la Main para 
        obtener:
        Todas las vocales que contiene un string.
        Solo los dígitos.
        Solo los caracteres minúsculas.
        Solo los caracteres y números. 
 */

namespace Lambda3
{
    public delegate bool Agrega(char caracter);

    class Program
    {
        public static string Filtrar(string cadena, Agrega agrega)
        {
            StringBuilder cadenaNueva = new StringBuilder();
            foreach (var caracter in cadena)
                if (agrega(caracter))
                    cadenaNueva.Append(caracter);
            return cadenaNueva.ToString();
        }

        static void Main(string[] args)
        {
            var cadena = "1 Hola 2 Mundo 3";
            Console.WriteLine("Cadena original:{0}", cadena);
            var cad1 = Program.Filtrar(cadena, caracter => caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                                                            caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U');
            Console.WriteLine("Solo las vocales: {0}", cad1);
            var cad2 = Program.Filtrar(cadena, caracter => char.IsDigit(caracter));
            Console.WriteLine("Solo los dígitos: {0}", cad2);
            var cad3 = Program.Filtrar(cadena, caracter => char.IsLower(caracter));
            Console.WriteLine("Solo los caracteres minúsculas: {0}", cad3);
            var cad4 = Program.Filtrar(cadena, caracter => char.IsLetter(caracter) || char.IsNumber(caracter));
            Console.WriteLine("Solo los caracteres y números: {0}", cad4);
            Console.ReadKey();
        }
    }
}
