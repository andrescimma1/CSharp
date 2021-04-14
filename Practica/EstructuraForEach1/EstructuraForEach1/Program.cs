using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Almacenar los sueldos de 5 operarios en un vector,
        imprimir los elementos recorriendo el vector con la
        estructura repetitiva foreach. 
 */

namespace EstructuraForEach1
{
    class SueldoEmpleados
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese valor de la componente:");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            foreach (int s in sueldos)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SueldoEmpleados pv = new SueldoEmpleados();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
