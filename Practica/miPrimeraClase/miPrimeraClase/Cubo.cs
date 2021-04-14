using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    class Cubo
    {
        // atributos
        private int lado;
        private int area;
        private int volumen;

        // constructores
        public Cubo()
        {
            lado = 5;
            area = 0;
            volumen = 0;
        }

        public Cubo(string entrada)
        {
            int numero = 0;
            try
            {
                numero = int.Parse(entrada);
            }
            catch
            {

            }

            this.lado = numero;
        }

        public int Lado // Primera forma
        {
            get
            {
                return lado;
            }

            set
            {
                lado = value;
            }
        }

        public int Area { get => area; set => area = value; } // Segunda forma (arrow)
        public int Volumen { get => volumen; set => volumen = value; }

        // métodos
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }

        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }
}
