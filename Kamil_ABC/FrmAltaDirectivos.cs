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
    public partial class FrmAltaDirectivos : Form
    {
        ConexionSqlServer conSql;
        Directivo empleado;
        bool estaActualizado = false;
        public FrmAltaDirectivos()
        {
            InitializeComponent();
        }

        public FrmAltaDirectivos(Directivo empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.estaActualizado = true;
        }

        private void FrmAltaDirectivos_Load(object sender, EventArgs e)
        {
            conSql = new ConexionSqlServer();
            LlenaComboCentros();
            LlenaComboCentrosSupervisa();
            LlenaComboPuestos();
            CargaDatosEmpleado();
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
                this.cbCentroSupervisa.SelectedIndex = cbCentro.FindString(this.empleado.numCentroSupervisa!.ToString());
                this.rbActivaPagoCombustible.Checked = Convert.ToBoolean(this.empleado.recibeCombustible);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenaComboCentros()
        {
            this.cbCentro.DataSource = conSql.ConsultaDatosCentro();
            this.cbCentro.ValueMember = "noCentro";
            this.cbCentro.DisplayMember = "unaSolaLinea";
            this.cbCentro.SelectedIndex = -1;
        }

        private void LlenaComboCentrosSupervisa()
        {
            this.cbCentroSupervisa.DataSource = conSql.ConsultaDatosCentro();
            this.cbCentroSupervisa.ValueMember = "noCentro";
            this.cbCentroSupervisa.DisplayMember = "unaSolaLinea";
            this.cbCentroSupervisa.SelectedIndex = -1;
        }

        private void LlenaComboPuestos()
        {
            this.cbPuesto.DataSource = conSql.ConsultaDatosPuesto();
            this.cbPuesto.ValueMember = "numeroPuesto";
            this.cbPuesto.DisplayMember = "puesto";
            this.cbPuesto.SelectedIndex = -1;
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
                                                     , 1);
                }
                else
                {
                    queryString = string.Format(@"UPDATE cat_empleados SET 
                                                     nom_empleado = '{0}'
                                                    ,ape_paterno = '{1}'
                                                    ,ape_materno = '{2}'
                                                    ,fec_nacimiento = '{3}'
                                                    ,num_centro = {4}
                                                    ,num_puesto = {5}
                                                    ,es_directivo = 1
                                                     WHERE num_empleado = {6};

                                                   UPDATE directivos SET 
                                                     num_centro_supervisa = {7}
                                                    ,recibe_combustible = {8}
                                                     WHERE num_empleado = {6};",
                                                       txtNombre.Text
                                                     , txtApePaterno.Text
                                                     , txtApeMaterno.Text
                                                     , dtpFechaNacimiento.Value.ToString("yyyy/MM/dd")
                                                     , cbCentro.SelectedValue
                                                     , cbPuesto.SelectedValue
                                                     , this.empleado!.noEmpleado
                                                     , cbCentroSupervisa.SelectedValue
                                                     , rbActivaPagoCombustible.Checked ? 1 : 0);
                }
                int registros = conSql.EjecutaNonQuery(queryString);

                if (registros > 0)
                {
                    if (!estaActualizado)
                    {
                        string num_empleado = conSql.Consulta("select MAX(num_empleado) from cat_empleados").ToString();

                        if (!string.IsNullOrWhiteSpace(num_empleado))
                        {
                            queryString = string.Format(@"INSERT INTO directivos VALUES (
                                                    {0},
                                                    {1},
                                                    {2})",
                                                        num_empleado,
                                                        cbCentroSupervisa.SelectedValue,
                                                        rbActivaPagoCombustible.Checked ? 1 : 0);
                            registros = conSql.EjecutaNonQuery(queryString);
                        }
                    }
                    

                    if (registros > 0)
                    {
                        MessageBox.Show("Se registro el usuario de manera correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("No se registro el usuario, favor de validar", "Fallo el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (this.empleado != null)
                {
                    this.Close();
                }
            }
        }

        
    }
}
