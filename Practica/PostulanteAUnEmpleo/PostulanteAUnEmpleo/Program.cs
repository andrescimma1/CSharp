using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostulanteAUnEmpleo
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPreguntas, totalCorrectas, porcentaje;
            string linea;

            Console.Write("Ingrese el total de las preguntas respondidas: ");
            linea = Console.ReadLine();
            totalPreguntas = int.Parse(linea);

            Console.Write("Ingrese el total de las preguntas correctas: ");
            linea = Console.ReadLine();
            totalCorrectas = int.Parse(linea);

            porcentaje = (totalCorrectas * 100) / totalPreguntas;

            if(porcentaje >= 90)
            {
                Console.Write("Nivel máximo");
            }
            else if(porcentaje >= 75 && porcentaje < 90)
            {
                Console.Write("Nivel medio");
            }
            else if(porcentaje >= 50 && porcentaje < 75)
            {
                Console.Write("Nivel regular");
            }
            else
            {
                Console.Write("Fuera de nivel");
            }

            Console.ReadKey();
        }
    }
}
