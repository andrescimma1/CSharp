using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Definir un atributo estático que almacene
        la cantidad de objetos creados de dicha clase. 
 */

namespace AtributosEstaticos1
{
    class Persona
    {
        private string nombre;
        private int edad;
        public static int cantidad;

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
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad);
            Persona per1 = new Persona("juan", 30);
            per1.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad);
            Persona per2 = new Persona("ana", 20);
            per2.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad);
            Persona per3 = new Persona("luis", 10);
            per3.Imprimir();
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad);
            Console.ReadKey();
        }
    }
}
