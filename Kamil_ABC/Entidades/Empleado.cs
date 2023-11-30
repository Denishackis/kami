using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil.Entidades
{
    internal class Empleado
    {
        public string? descripcionPuesto { get; set; }
        public string? noEmpleado { get; set; }
        public string? nombre { get; set; }
        public string? apellidoP { get; set; }
        public string? apellidoM { get; set; }
        public string? fechaNacimiento { get; set; }
        public string? RFC { get; set; }
        public centroTrabajo? centroTrabajo { get; set; }
        public Puesto? puesto { get; set; }
       
    }
}
