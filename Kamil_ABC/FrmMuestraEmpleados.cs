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
            FormateaGrid();
            LlenaRegistrosGrid(conSql.ConsultaEmpleados());
        }

        private void FormateaGrid()
        {
            DataGridViewButtonColumn gb_modificar = new DataGridViewButtonColumn();
            gb_modificar.Name = "GridBtnModificar";
            gb_modificar.Text = "Click";
            gb_modificar.HeaderText = "Modificar datos";
            gb_modificar.UseColumnTextForButtonValue = true;
            dgvEmpleados.Columns.Add(gb_modificar);

            DataGridViewButtonColumn gb_eliminar = new DataGridViewButtonColumn();
            gb_eliminar.Name = "GridBtnEliminar";
            gb_eliminar.Text = "Eliminar";
            gb_eliminar.HeaderText = "Baja empleado";
            gb_eliminar.UseColumnTextForButtonValue = true;
            dgvEmpleados.Columns.Add(gb_eliminar);

            this.dgvEmpleados.Columns.Add("num_empleado", "Id empleado");
            this.dgvEmpleados.Columns.Add("nom_empleado", "Nombre");
            this.dgvEmpleados.Columns.Add("ape_paterno", "Apellido paterno");
            this.dgvEmpleados.Columns.Add("ape_materno", "Apellido materno");
            this.dgvEmpleados.Columns.Add("fec_nacimiento", "Fecha de nacimiento");
            this.dgvEmpleados.Columns.Add("num_centro", "Id centro");
            this.dgvEmpleados.Columns.Add("nom_centro", "Centro");
            this.dgvEmpleados.Columns.Add("nom_ciudad", "Ciudad");
            this.dgvEmpleados.Columns.Add("num_puesto", "Id puesto");
            this.dgvEmpleados.Columns.Add("nom_puesto", "Puesto");
            this.dgvEmpleados.Columns.Add("des_puesto", "Descripción del puesto");
        }

        private void LlenaRegistrosGrid(List<Empleado> listaEmpleados)
        {
            foreach (Empleado emp in listaEmpleados)
            {
                this.dgvEmpleados.Rows.Add(
                        "",
                        "",
                        emp.noEmpleado,
                        emp.nombre,
                        emp.apellidoP,
                        emp.apellidoM,
                        Convert.ToDateTime(emp.fechaNacimiento).ToShortDateString(),
                        emp.centroTrabajo!.noCentro,
                        emp.centroTrabajo.nombreCentro,
                        emp.centroTrabajo.ciudad,
                        emp.puesto!.numeroPuesto,
                        emp.puesto.puesto,
                        emp.puesto.descripcion);
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmpleados.Columns["GridBtnModificar"].Index)
            {
                using (FrmAltaEmpleados frmAltaEmpleado = new FrmAltaEmpleados(new Empleado(
                                                                                            Convert.ToInt32(this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value),
                                                                                            this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_empleado"].Value.ToString(),
                                                                                            this.dgvEmpleados.Rows[e.RowIndex].Cells["ape_paterno"].Value.ToString(),
                                                                                            this.dgvEmpleados.Rows[e.RowIndex].Cells["ape_materno"].Value.ToString(),
                                                                                            Convert.ToDateTime(this.dgvEmpleados.Rows[e.RowIndex].Cells["fec_nacimiento"].Value),
                                                                                            new CentroTrabajo(
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["num_centro"].Value.ToString(),
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_centro"].Value.ToString(),
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_ciudad"].Value.ToString()),
                                                                                            new Puesto(
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["num_puesto"].Value.ToString(),
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_puesto"].Value.ToString(),
                                                                                                    this.dgvEmpleados.Rows[e.RowIndex].Cells["des_puesto"].Value.ToString())
                                                                                            )))
                {
                    frmAltaEmpleado.ShowDialog();
                    this.dgvEmpleados.Rows.Clear();
                    LlenaRegistrosGrid(conSql.ConsultaEmpleados());
                }
            }
            else if (e.ColumnIndex == dgvEmpleados.Columns["GridBtnEliminar"].Index)
            {
                if(MessageBox.Show(string.Format("Estas apunto de eliminar el registro del empleado #{0} - {1}.\n¿estas seguro?", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value, this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_empleado"].Value.ToString())
                    ,"Dar de baja empleado",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(conSql.EjecutaNonQuery(string.Format("DELETE FROM cat_empleados WHERE num_empleado = {0}", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value)) == 1)
                    {
                        MessageBox.Show("Empleado dado de baja con exito","Existoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.dgvEmpleados.Rows.Clear();
                        LlenaRegistrosGrid(conSql.ConsultaEmpleados());
                    }else
                    {
                        MessageBox.Show("Ocurrio un error al intentar dar de baja al empleado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

            
        }
    }
}
