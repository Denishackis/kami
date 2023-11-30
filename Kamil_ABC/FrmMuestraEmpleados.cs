using ProyectoKamil.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class FrmMuestraEmpleados : Form
    {
        ConexionSqlServer conSql;
        public FrmMuestraEmpleados()
        {
            InitializeComponent();
            this.conSql = new ConexionSqlServer();
        }

        private void FrmMuestraEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = conSql.ConsultaEmpleados();
        }
    }
}
