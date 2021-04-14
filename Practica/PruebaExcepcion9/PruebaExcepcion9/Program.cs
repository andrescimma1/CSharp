using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Declarar una clase 'Cliente' que represente
        un cliente de un banco. Definir las siguientes
        propiedades y métodos:

        Cliente		
            Propiedades
                Nombre
                Monto
            métodos
                constructor
                Depositar
                Extraer
                Imprimir
        Generar una excepción si se intenta extraer 
        más dinero del que tiene la propiedad 'Monto'.
 */

namespace PruebaExcepcion9
{
    class Cliente
    {
        private string Nombre { get; set; }
        private int Monto { get; set; }

        public Cliente(string nombre, int monto)
        {
            Nombre = nombre;
            Monto = monto;
        }

        public void Depositar()
        {
            Console.Write("Ingrese el monto a depositar: ");
            string linea = Console.ReadLine();
            int deposito = int.Parse(linea);

            Monto += deposito;

            Console.WriteLine($"Ahora tienes ${Monto}");
        }

        public void Extraer()
        {
            Console.WriteLine("Ingrese el monto a extraer: ");
            string linea = Console.ReadLine();
            int extraccion = int.Parse(linea);

            if(extraccion > Monto)
            {
                throw new Exception("Monto a extraer mayor a monto actual.");
            }

            Monto -= extraccion;
        }

        public void Imprimir()
        {
            Console.WriteLine($"{Nombre}, su monto actual es {Monto}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Andrés", 40000);
            cliente1.Depositar();
            cliente1.Imprimir();
            try
            {
                cliente1.Extraer();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
