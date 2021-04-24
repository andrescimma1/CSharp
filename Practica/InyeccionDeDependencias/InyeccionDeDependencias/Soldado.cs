using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    class Soldado
    {
        private IArma arma;

        public Soldado(IArma _arma)
        {
            this.arma = _arma;
        }

        public void CambiarArma(IArma _arma)
        {
            this.arma = _arma;
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }
}
