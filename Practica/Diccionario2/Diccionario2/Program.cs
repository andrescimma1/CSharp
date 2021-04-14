using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Almacenar un diccionario como 'clave' 
        el código de producto y como valor objetos
        de la clase Producto que definan las 
        propiedades 'Descripción' y 'Precio'.
        Almacenar varios artículos en el diccionario
        y luego imprimirlo.
        Ingresar un código de artículo por teclado
        y luego mostrar su descripción y precio. 
 */

namespace Diccionario2
{
    class Producto
    {
        public String Descripcion { get; set; }
        public float Precio { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var articulos = new Dictionary<int, Producto>();
            articulos[1] = new Producto { Descripcion = "Papas", Precio = 12.67f };
            articulos[2] = new Producto { Descripcion = "Manzanas", Precio = 20f };
            articulos[3] = new Producto { Descripcion = "Naranjas", Precio = 25f };
            foreach (KeyValuePair<int, Producto> art in articulos)
                Console.WriteLine(art.Key + " " + art.Value.Descripcion + " " + art.Value.Precio);
            Console.Write("Ingrese el código de producto a consultar:");
            int codigo = int.Parse(Console.ReadLine());
            if (articulos.ContainsKey(codigo))
                Console.WriteLine(articulos[codigo].Descripcion + " " + articulos[codigo].Precio);
            else
                Console.WriteLine("No existe un artículo con dicho código");
            Console.ReadKey();
        }
    }
}
