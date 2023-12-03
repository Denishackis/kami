using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil.Entidades
{
    public class Puesto
    {
        public string? numeroPuesto { get; set; }
        public string? puesto { get; set; }
        public string? descripcion { get; set; }

        public Puesto(string numeroPuesto, string puesto, string descripcion)
        {
            this.numeroPuesto = numeroPuesto;
            this.puesto = puesto;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.numeroPuesto, this.puesto);
        }
    }
}
