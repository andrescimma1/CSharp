using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado = new Soldado(new Revolver());
            Soldado soldado2 = new Soldado(new Rifle());
            Soldado soldado3 = new Soldado(new Escopeta());

            Console.WriteLine(soldado.Disparar()); // Revolver
            soldado.CambiarArma(new Escopeta()); // Cambio a escopeta
            Console.WriteLine(soldado.Disparar()); // Escopeta
            Console.WriteLine(soldado2.Disparar());
            Console.WriteLine(soldado3.Disparar());

            Console.ReadKey();
        }
    }
}
