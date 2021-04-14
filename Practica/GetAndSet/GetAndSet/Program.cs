using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Plantear una clase Club y otra clase Socio. La clase Socio 
 * debe tener los siguientes atributos privados: nombre y la 
 * antigüedad en el club (en años) Definir dos propiedades para 
 * poder acceder al nombre y la antigüedad del socio(no permitir 
 * cargar un valor negativo en la antigüedad). La clase Club debe 
 * tener como atributos 3 objetos de la clase Socio. Definir una 
 * responsabilidad para imprimir el nombre del socio con mayor 
 * antigüedad en el club. */

namespace GetAndSet
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Antiguedad
        {
            set
            {
                if(antiguedad >= 0)
                {
                    antiguedad = value;
                }
                else
                {
                    Console.Write("No se puede tener una antiguedad negativa");
                }
                
            }
            get
            {
                return antiguedad;
            }
        }

        public void Cargar()
        {
            string linea;

            Console.Write("Ingrese nombre: ");
            linea = Console.ReadLine();
            Nombre = linea;

            Console.Write("Ingrese antiguedad: ");
            linea = Console.ReadLine();
            Antiguedad = int.Parse(linea);
        }
    }

    class Club
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio();
            Socio socio2 = new Socio();
            Socio socio3 = new Socio();

            socio1.Cargar();
            socio2.Cargar();
            socio3.Cargar();

            if(socio1.Antiguedad > socio2.Antiguedad
                && socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.Write(socio1.Nombre);
            }

            if (socio2.Antiguedad > socio1.Antiguedad
                && socio2.Antiguedad > socio3.Antiguedad)
            {
                Console.Write(socio2.Nombre);
            }

            if (socio3.Antiguedad > socio1.Antiguedad
                && socio3.Antiguedad > socio2.Antiguedad)
            {
                Console.Write(socio3.Nombre);
            }

            Console.ReadKey();
        }
    }
}
