using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple
{
    class Point3D : Point
    {
        private int z;

        public int Z { get => z; set => z = value; }


        public override void MostrarMensaje()
        {
            // "override" sirve para redefinir desde
            //  la clase hija
            Console.WriteLine("Método invocado desde la clase Point3D");
        }
    }
}
