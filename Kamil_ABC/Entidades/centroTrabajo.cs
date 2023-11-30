using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil.Entidades
{
    public class CentroTrabajo
    {
        public string? noCentro { get; }
        public string? nombreCentro { get; }
        public string? ciudad { get; }
        public string? unaSolaLinea { get {
                return string.Format("{0} - {1} de {2}", this.noCentro, this.nombreCentro, this.ciudad);
            }
        }

        public CentroTrabajo(string noCentro, string nombreCentro, string ciudad)
        {
            this.noCentro = noCentro;
            this.nombreCentro = nombreCentro;
            this.ciudad = ciudad;
        }

        public override string ToString() {
            return string.Format("{0} - {1} de {2}", this.noCentro, this.nombreCentro, this.ciudad);
        }
    }
}
