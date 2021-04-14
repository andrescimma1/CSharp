using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Plantear una clase Club y otra clase Socio. La clase Socio debe tener
 * los siguientes atributos privados: nombre y la antigüedad en el
 * club (en años). En el constructor pedir la carga del nombre y su
 * antigüedad. La clase Club debe tener como atributos 3 objetos de la 
 * clase Socio. Definir una responsabilidad para imprimir el nombre del 
 * socio con mayor antigüedad en el club. */

namespace ColaboracionDeClases
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            string linea;

            Console.Write("Ingrese el nombre del socio: ");
            linea = Console.ReadLine();
            nombre = linea;

            Console.Write("Ingrese la antiguedad del socio: ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }

        public void Imprimir()
        {
            Console.Write("El socio con mayor antiguedad es: " + nombre);
        }
    }

    class Club
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio();
            Socio socio2 = new Socio();
            Socio socio3 = new Socio();

            if(socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad()
                && socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }

            if (socio2.RetornarAntiguedad() > socio1.RetornarAntiguedad()
                && socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio2.Imprimir();
            }

            if (socio3.RetornarAntiguedad() > socio1.RetornarAntiguedad()
                && socio3.RetornarAntiguedad() > socio2.RetornarAntiguedad())
            {
                socio3.Imprimir();
            }

            Console.ReadKey();
        }
    }
}
