using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencia
{
    class Documento
    {
        private string texto = "";

        public string Texto { get => texto; }

        public Documento(string texto)
        {
            this.texto = texto;
        }

        
    }
}
