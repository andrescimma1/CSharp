using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia lab2 = new Materia("Laboratorio 2");

            Tema tema1 = new Tema("Orientación a Objetos");
            Tema tema2 = new Tema("Windows Forms");

            lab2.AgregarTema(tema1);
            lab2.AgregarTema(tema2);

            foreach(Tema t in lab2.Temas)
            {
                Console.WriteLine(lab2.Nombre + ": " + t.Nombre);
            }

            tema1.Materia = lab2;
            tema2.Materia = lab2;

            Console.WriteLine(tema1.Nombre + ": " + tema1.Materia.Nombre);
            Console.WriteLine(tema2.Nombre + ": " + tema2.Materia.Nombre);

            Console.ReadKey();
        }
    }
}
