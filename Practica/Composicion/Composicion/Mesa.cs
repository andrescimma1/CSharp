using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    class Mesa
    {
        private List<Pata> patas;
        internal List<Pata> Patas { get => patas; }


        // constructor
        public Mesa(int cantidadDePatas)
        {
            this.patas = new List<Pata>();

            for(int i = 0; i < cantidadDePatas; i++)
            {
                this.patas.Add(new Pata());
            }
        }

        // clase anidada (tiene que ser interna)
        internal class Pata
        {
            public string color = "Blanco";
        }
    }
}
