using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Materia
    {
        private string nombre;
        private List<Tema> temas;

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Tema> Temas { get => temas; }

        public Materia(string nombre)
        {
            this.nombre = nombre;
            this.temas = new List<Tema>();
        }

        public void AgregarTema(Tema t)
        {
            temas.Add(t);
        }

    }
}
