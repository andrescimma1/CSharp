using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Tema
    {
        private string nombre;
        private Materia materia;
        public string Nombre { get => nombre; set => nombre = value; }
        internal Materia Materia { get => materia; set => materia = value; }

        public Tema(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
