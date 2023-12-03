using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil.Entidades
{
    public class Directivo : Empleado
    {
        public string? numCentroSupervisa { get; set; }
        public bool? recibeCombustible { get; set; }

        public Directivo(int noEmpleado, string nombre, string apellidoP, string apellidoM,
            DateTime fechaNacimiento, CentroTrabajo centroTrabajo, Puesto puesto, string numCentroSupervisa, bool recibeCombustible) : base (noEmpleado, nombre,apellidoP,apellidoM,fechaNacimiento,centroTrabajo, puesto)
        {
            this.numCentroSupervisa = numCentroSupervisa;
            this.recibeCombustible = recibeCombustible;
        }

    }
}
