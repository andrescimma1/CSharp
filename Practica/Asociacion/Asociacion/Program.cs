using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia lab2 = new Materia("Laboratorio 2");
            Materia lab3 = new Materia("Laboratorio 3");
            ProfesorTitular profeJesu = new ProfesorTitular("Jesús Arce");
            
            lab2.Profesor = profeJesu;
            lab3.Profesor = profeJesu;

            profeJesu.AgregarMateria(lab2);
            profeJesu.AgregarMateria(lab3);

            foreach(Materia m in profeJesu.Materias)
            {
                Console.WriteLine(m.Nombre);
            }

            Console.WriteLine(lab2.Nombre + ": " + lab2.Profesor.Nombre);
            Console.WriteLine(lab3.Nombre + ": " + lab3.Profesor.Nombre);

            Console.ReadKey();
        }
    }
}
