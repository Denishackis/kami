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
    public partial class FrmAltaCentros : Form
    {
        ConexionSqlServer conSql;
        CentroTrabajo centro;
        bool estaActualizado = false;
        public FrmAltaCentros()
        {
            InitializeComponent();
        }

        public FrmAltaCentros(CentroTrabajo centro)
        {
            InitializeComponent();
            this.centro = centro;
            this.estaActualizado = true;
        }

        private void FrmAltaCentros_Load(object sender, EventArgs e)
        {
            conSql = new ConexionSqlServer();
            CargaDatosCentro();
        }

        private void CargaDatosCentro()
        {
            if (this.centro != null)
            {
                this.txtNombreCentro.Text = this.centro.nombreCentro;
                this.txtNumeroCentro.Text = this.centro.noCentro;
                this.txtNombreCiudad.Text = this.centro.ciudad;
                this.txtNumeroCentro.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validaCampos()
        {
            bool respuesta = true;

            if (string.IsNullOrWhiteSpace(this.txtNombreCentro.Text))
            {
                MessageBox.Show("Favor de llenar el campo Nombre centro", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtNombreCentro.Focus();
                respuesta = false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtNumeroCentro.Text))
            {
                MessageBox.Show("Favor de llenar el campo Número centro", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtNumeroCentro.Focus();
                respuesta = false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombreCiudad.Text))
            {
                MessageBox.Show("Favor de llenar el campo Nombre ciudad", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtNombreCiudad.Focus();
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
                    queryString = string.Format(@"INSERT INTO cat_centros (
                                                     num_centro
                                                    ,nom_centro
                                                    ,nom_ciudad) VALUES (
                                                      {0}
                                                    ,'{1}'
                                                    ,'{2}')",
                                                       txtNumeroCentro.Text
                                                     , txtNombreCentro.Text
                                                     , txtNombreCiudad.Text);
                }
                else
                {
                    queryString = string.Format(@"UPDATE cat_centros SET
                                                     nom_centro = '{1}'
                                                    ,nom_ciudad = '{2}'
                                                     WHERE num_centro = {0}",
                                                       txtNumeroCentro.Text
                                                     , txtNombreCentro.Text
                                                     , txtNombreCiudad.Text);
                }
                int registros = conSql.EjecutaNonQuery(queryString);

                if (registros == 1)
                {
                    MessageBox.Show("Se registro el centro de manera correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se registro el centro, favor de validar", "Fallo el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (this.centro != null)
                {
                    this.Close();
                }
            }
        }
    }
}
