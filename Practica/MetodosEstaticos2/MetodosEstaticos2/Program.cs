using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto
        Plantear una clase llamada VectorEnteros
        que defina tres métodos estáticos. El 
        primero retorna el mayor elemento del vector
        (el vector llega como parámetro), el segundo 
        el menor elemento y el tercero la suma de sus
        componentes. 
 */

namespace MetodosEstaticos2
{
    class Program
    {
        class VectorEnteros
        {
            public static int Mayor(int [] v)
            {
                int mayor = 0;
                bool flag = false;

                for(int i=0; i<v.Length; i++)
                {
                    if(!flag)
                    {
                        mayor = v[i];
                        flag = true;
                    }

                    if(v[i] > mayor)
                    {
                        mayor = v[i];
                    }
                }

                return mayor;
            }

            public static int Menor(int[] v)
            {
                int menor = 0;
                bool flag = false;

                for (int i = 0; i < v.Length; i++)
                {
                    if (!flag)
                    {
                        menor = v[i];
                        flag = true;
                    }

                    if (v[i] < menor)
                    {
                        menor = v[i];
                    }
                }

                return menor;
            }

            public static int Suma(int[] v)
            {
                int suma = 0;

                for (int i = 0; i < v.Length; i++)
                {
                    suma += v[i];
                }

                return suma;
            }
        }

        static void Main(string[] args)
        {
            int[] numeros = { 7, 4, 8 };

            Console.WriteLine("El mayor numero del vector es: " + VectorEnteros.Mayor(numeros));
            Console.WriteLine("El menor numero del vector es: " + VectorEnteros.Menor(numeros));
            Console.WriteLine("La suma de todos los numeros es: " + VectorEnteros.Suma(numeros));

            Console.ReadKey();
        }
    }
}
