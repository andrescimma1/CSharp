using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.MostrarMensaje();

            Point3D p3d = new Point3D();
            p3d.MostrarMensaje();

            Console.ReadKey();
        }
    }
}
