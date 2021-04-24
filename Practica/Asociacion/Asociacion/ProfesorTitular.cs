using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class ProfesorTitular
    {
        // atributos
        private string nombre;
        private List<Materia> materias = new List<Materia>();

        public string Nombre { get => nombre; }
        internal List<Materia> Materias { get => materias; }

        // constructor
        public ProfesorTitular(string nombre)
        {
            this.nombre = nombre;
        }

        // métodos
        public void AgregarMateria(Materia materia)
        {
            Materias.Add(materia);
        }
    }
}
