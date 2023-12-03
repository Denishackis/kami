using ProyectoKamil.Conexion;
using ProyectoKamil.Entidades;
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
    public partial class FrmAltaEmpleados : Form
    {
        ConexionSqlServer? conSql;
        Empleado? empleado;
        bool estaActualizado = false;
        public FrmAltaEmpleados()
        {
            InitializeComponent();
        }

        public FrmAltaEmpleados(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.estaActualizado = true;
        }

        private void FrmAltaEmpleados_Load(object sender, EventArgs e)
        {
            conSql = new ConexionSqlServer();
            LlenaComboCentros();
            LlenaComboPuestos();
            CargaDatosEmpleado();
        }

        private void LlenaComboCentros()
        {
            this.cbCentro.DataSource = conSql.ConsultaDatosCentro();
            this.cbCentro.ValueMember = "noCentro";
            this.cbCentro.DisplayMember = "unaSolaLinea";
            this.cbCentro.SelectedIndex = -1;
        }

        private void LlenaComboPuestos()
        {
            this.cbPuesto.DataSource = conSql.ConsultaDatosPuesto();
            this.cbPuesto.ValueMember = "numeroPuesto";
            this.cbPuesto.DisplayMember = "puesto";
            this.cbPuesto.SelectedIndex = -1;
        }

        private void CargaDatosEmpleado()
        {
            if (this.empleado != null)
            {
                this.txtNombre.Text = this.empleado.nombre;
                this.txtApePaterno.Text = this.empleado.apellidoP;
                this.txtApeMaterno.Text = this.empleado.apellidoM;
                this.dtpFechaNacimiento.Value = Convert.ToDateTime(this.empleado.fechaNacimiento);
                this.cbCentro.SelectedIndex = cbCentro.FindString(this.empleado.centroTrabajo!.ToString());
                this.cbPuesto.SelectedIndex = cbPuesto.FindString(this.empleado.puesto!.puesto);
            }
        }

        private bool validaCampos()
        {
            bool respuesta = true;

            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Favor de llenar el campo Nombre", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtNombre.Focus();
                respuesta = false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtApePaterno.Text))
            {
                MessageBox.Show("Favor de llenar el campo Apellido paterno", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtApePaterno.Focus();
                respuesta = false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtApeMaterno.Text))
            {
                MessageBox.Show("Favor de llenar el campo Apellido materno", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtApeMaterno.Focus();
                respuesta = false;
            }
            else if (this.dtpFechaNacimiento.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
            {
                MessageBox.Show("Favor de llenar la fecha de nacimiento", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.dtpFechaNacimiento.Focus();
                respuesta = false;
            }
            else if (this.cbCentro.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de Seleccionar el centro al que pertenece el empleado", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cbCentro.Focus();
                respuesta = false;
            }
            else if (this.cbPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de Seleccionar el puesto del empleado", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cbPuesto.Focus();
                respuesta = false;
            }

            return respuesta;
        }

        private void limpiarCampos()
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                string queryString = "";

                if (!estaActualizado)
                {
                    queryString = string.Format(@"INSERT INTO cat_empleados (
                                                     nom_empleado
                                                    ,ape_paterno
                                                    ,ape_materno
                                                    ,fec_nacimiento
                                                    ,num_centro
                                                    ,num_puesto
                                                    ,es_directivo) VALUES (
                                                     '{0}'
                                                    ,'{1}'
                                                    ,'{2}'
                                                    ,'{3}'
                                                    ,{4}
                                                    ,{5}
                                                    ,{6})",
                                                       txtNombre.Text
                                                     , txtApePaterno.Text
                                                     , txtApeMaterno.Text
                                                     , dtpFechaNacimiento.Value.ToString("yyyy/MM/dd")
                                                     , cbCentro.SelectedValue
                                                     , cbPuesto.SelectedValue
                                                     , 0);
                }else
                {
                    queryString = string.Format(@"UPDATE cat_empleados SET 
                                                     nom_empleado = '{0}'
                                                    ,ape_paterno = '{1}'
                                                    ,ape_materno = '{2}'
                                                    ,fec_nacimiento = '{3}'
                                                    ,num_centro = {4}
                                                    ,num_puesto = {5}
                                                    ,es_directivo = 0
                                                     WHERE num_empleado = {6}",
                                                       txtNombre.Text
                                                     , txtApePaterno.Text
                                                     , txtApeMaterno.Text
                                                     , dtpFechaNacimiento.Value.ToString("yyyy/MM/dd")
                                                     , cbCentro.SelectedValue
                                                     , cbPuesto.SelectedValue
                                                     , this.empleado!.noEmpleado); ;
                }

                int registros = conSql!.EjecutaNonQuery(queryString);

                if (registros == 1)
                {
                    MessageBox.Show("Se registro el usuario de manera correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se registro el usuario, favor de validar", "Fallo el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
