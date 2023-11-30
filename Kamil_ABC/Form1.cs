using ProyectoKamil.Conexion;
using ProyectoKamil.Entidades;

namespace ABC_tarea
{
    public partial class Form1 : Form
    {
        private ConexionSqlServer conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new ConexionSqlServer();

        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (conexion.ProbarConexion())
            {
                lbl_estado.Text = "Conexión establecida";
                lbl_estado.ForeColor = System.Drawing.Color.Green;
                btn_conectar.Enabled = false;
            }else
            {
                MessageBox.Show("No fue posible conectar con la base de datos","Fallo la conexión",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
