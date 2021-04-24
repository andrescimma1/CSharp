using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Materia
    {
        // atributos
        private string nombre;
        private ProfesorTitular profesor;

        public string Nombre { get => nombre; }
        internal ProfesorTitular Profesor { get => profesor; set => profesor = value; }

        // constructor
        public Materia(string nombre)
        {
            this.nombre = nombre;
        } 
    }
}
