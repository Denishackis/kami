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

        private void btnVerEmpleado_Click(object sender, EventArgs e)
        {
            using (FrmMuestraEmpleados frmMuestraEmpleado = new FrmMuestraEmpleados())
            {
                frmMuestraEmpleado.ShowDialog();
            }
        }
    }
}
