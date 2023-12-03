using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil.Entidades
{
    public class Empleado
    {
        public int? noEmpleado { get; set; }
        public string? nombre { get; set; }
        public string? apellidoP { get; set; }
        public string? apellidoM { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public string RFC { get
            {
                List<string> list = new List<string>()
                {
                    "A","E","I","O","U"
                };
                return string.Format("{0}{1}{2}{3}{4}{5}{6}"
                                             , this.apellidoP.Substring(0,1).ToUpper()
                                             , this.apellidoP.FirstOrDefault(x => list.Contains(x.ToString().ToUpper()),'X').ToString().ToUpper()
                                             , this.apellidoM.Substring(0,1).ToUpper()
                                             , this.nombre.Substring(0, 1).ToUpper()
                                             , this.fechaNacimiento!.Value.Year.ToString().Substring(2, 2).PadLeft(2, '0')
                                             , this.fechaNacimiento!.Value.Month.ToString().PadLeft(2, '0')
                                             , this.fechaNacimiento!.Value.Day.ToString().PadLeft(2,'0'));
            }
        }
        public CentroTrabajo? centroTrabajo { get; set; }
        public Puesto? puesto { get; set; }

        public Empleado(int noEmpleado, string nombre, string apellidoP, string apellidoM,
            DateTime fechaNacimiento, CentroTrabajo centroTrabajo, Puesto puesto)
        {
            this.noEmpleado = noEmpleado;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.fechaNacimiento = fechaNacimiento;
            this.centroTrabajo = centroTrabajo;
            this.puesto = puesto;
        }

    }
}
