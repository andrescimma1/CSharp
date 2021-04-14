using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 2:
        Definir una propiedad estática para 
        acceder a un atributo estático que 
        guarda la cantidad de objetos creados 
        de dicha clase. 
 */

namespace PropiedadesEstaticas1
{
    class Persona
    {
        private string nombre;
        private int edad;
        private static int cantidad;

        public static int Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        public Persona(string nom, int ed)
        {
            cantidad++;
            nombre = nom;
            edad = ed;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + "-" + edad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.Cantidad);
            Persona per1 = new Persona("juan", 30);
            per1.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.Cantidad);
            Persona per2 = new Persona("ana", 20);
            per2.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.Cantidad);
            Persona per3 = new Persona("luis", 10);
            per3.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.Cantidad);
            Console.ReadKey();
        }
    }
}
