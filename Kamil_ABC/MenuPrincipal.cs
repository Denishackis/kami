using ProyectoKamil;
using ProyectoKamil.Conexion;
using ProyectoKamil.Entidades;

namespace ABC_tarea
{
    public partial class MenuPrincipal : Form
    {
        private ConexionSqlServer conexion;
        public MenuPrincipal()
        {
            InitializeComponent();
            conexion = new ConexionSqlServer();
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            using (FrmAltaEmpleados frmAltaEmpleado = new FrmAltaEmpleados())
            {
                frmAltaEmpleado.ShowDialog();
            }
        }

        private void btnAltaCentro_Click(object sender, EventArgs e)
        {
            using (FrmAltaCentros frmAltaCentros = new FrmAltaCentros())
            {
                frmAltaCentros.ShowDialog();
            }
        }

        private void btnAltaDirectivo_Click(object sender, EventArgs e)
        {
            using (FrmAltaDirectivos frmAltaDirectivos = new FrmAltaDirectivos())
            {
                frmAltaDirectivos.ShowDialog();
            }
        }

        private void btnVerEmpleado_Click(object sender, EventArgs e)
        {
            using (FrmMuestraDatos frmMuestraEmpleado = new FrmMuestraDatos(EnumOpciones.Empleados))
            {
                frmMuestraEmpleado.ShowDialog();
            }
        }

        private void btnVerDirectivo_Click(object sender, EventArgs e)
        {
            using (FrmMuestraDatos frmMuestraEmpleado = new FrmMuestraDatos(EnumOpciones.Directivos))
            {
                frmMuestraEmpleado.ShowDialog();
            }
        }

        private void btnVerCentro_Click(object sender, EventArgs e)
        {
            using (FrmMuestraDatos frmMuestraEmpleado = new FrmMuestraDatos(EnumOpciones.Centros))
            {
                frmMuestraEmpleado.ShowDialog();
            }
        }
    }
}
