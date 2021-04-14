using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Declarar una clase llamada 'PersonaAdulta' 
        con las propiedades Nombre y Edad. Lanzar 
        una excepción de tipo Exception en caso que
        llegue en el constructor una edad menor a 18
        años, o se intente modificar la propiedad Edad
        con un valor menor a 18.

        En este problema hemos tomado la decisión de 
        validar y lanzar una excepción en caso que se
        intente la creación de un objeto de la clase 
        PersonaAdulta con una edad inferior a 18. Esto 
        es porque a juicio del programador considera que
        es muy importante que nunca haya un objeto de 
        tipo PersonaAdulta que sea menor de edad. 
 */

namespace PruebaExcepcion7
{
    public class PersonaAdulta
    {
        public string Nombre { get; set; }

        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 18)
                    throw new Exception($"No es adulta la persona {Nombre} porque tiene {value} años.");
                edad = value;
            }

        }

        public PersonaAdulta(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void imprimir()
        {
            Console.WriteLine($"{Nombre} - {Edad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonaAdulta persona1 = new PersonaAdulta("Ana", 50);
                persona1.imprimir();
                PersonaAdulta persona2 = new PersonaAdulta("Juan", 13);
                persona2.imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
