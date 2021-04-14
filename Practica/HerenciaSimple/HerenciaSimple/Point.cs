using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple
{
    class Point
    {
        // atributos
        protected int x; // protected es heredado por clases hijas
        protected int y;

        // propiedades
        
        // public también es heredado por clases hijas
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        // constructores
        // ...

        // métodos
        // ...
        public virtual void MostrarMensaje()
        {
            // "virtual" sirve para que el método pueda ser
            //  redefinido en las clases hijas
            Console.WriteLine("Método invocado desde la clase Point");
        }

    }
}
