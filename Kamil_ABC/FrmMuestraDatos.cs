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
    public partial class FrmMuestraDatos : Form
    {
        ConexionSqlServer conSql;
        EnumOpciones opcionMenu;
        public FrmMuestraDatos(EnumOpciones opcionMenu)
        {
            InitializeComponent();
            this.conSql = new ConexionSqlServer();
            this.opcionMenu = opcionMenu;
        }

        private void FrmMuestraEmpleados_Load(object sender, EventArgs e)
        {
            FormateaGrid();
            LlenaRegistrosGrid();
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
            gb_eliminar.HeaderText = "Dar de baja";
            gb_eliminar.UseColumnTextForButtonValue = true;
            dgvEmpleados.Columns.Add(gb_eliminar);

            switch (opcionMenu)
            {
                case EnumOpciones.Empleados:
                    FormatoGridEmpleado();
                    break;
                case EnumOpciones.Directivos:
                    FormatoGridEmpleado();
                    FormatoGridDirectivo();
                    break;
                case EnumOpciones.Centros:
                    FormatoGridCentro();
                    break;
            }
        }

        private void FormatoGridEmpleado()
        {
            this.dgvEmpleados.Columns.Add("num_empleado", "Id empleado");
            this.dgvEmpleados.Columns.Add("nom_empleado", "Nombre");
            this.dgvEmpleados.Columns.Add("ape_paterno", "Apellido paterno");
            this.dgvEmpleados.Columns.Add("ape_materno", "Apellido materno");
            this.dgvEmpleados.Columns.Add("fec_nacimiento", "Fecha de nacimiento");
            this.dgvEmpleados.Columns.Add("des_rfc", "RFC");
            this.dgvEmpleados.Columns.Add("num_centro", "Id centro");
            this.dgvEmpleados.Columns.Add("nom_centro", "Centro");
            this.dgvEmpleados.Columns.Add("nom_ciudad", "Ciudad");
            this.dgvEmpleados.Columns.Add("num_puesto", "Id puesto");
            this.dgvEmpleados.Columns.Add("nom_puesto", "Puesto");
            this.dgvEmpleados.Columns.Add("des_puesto", "Descripción del puesto");
        }

        private void FormatoGridDirectivo()
        {
            this.dgvEmpleados.Columns.Add("num_centro_supervisa", "Id centro que supervisar");
            this.dgvEmpleados.Columns.Add("recibe_combustible", "Recibe combustible");
        }

        private void FormatoGridCentro()
        {
            this.dgvEmpleados.Columns.Add("num_centro", "Id centro");
            this.dgvEmpleados.Columns.Add("nom_centro", "Centro");
            this.dgvEmpleados.Columns.Add("nom_ciudad", "Ciudad");
        }

        private void LlenaRegistrosGrid()
        {
            switch (this.opcionMenu)
            {
                case EnumOpciones.Empleados:
                    List<Empleado> listaEmpleados = conSql.ConsultaEmpleados();

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
                                emp.RFC,
                                emp.centroTrabajo!.noCentro,
                                emp.centroTrabajo.nombreCentro,
                                emp.centroTrabajo.ciudad,
                                emp.puesto!.numeroPuesto,
                                emp.puesto.puesto,
                                emp.puesto.descripcion);
                    }
                    break;
                case EnumOpciones.Directivos:
                    List<Directivo> listaDirectivos = conSql.ConsultaDirectivos();

                    foreach (Directivo emp in listaDirectivos)
                    {
                        this.dgvEmpleados.Rows.Add(
                                "",
                                "",
                                emp.noEmpleado,
                                emp.nombre,
                                emp.apellidoP,
                                emp.apellidoM,
                                Convert.ToDateTime(emp.fechaNacimiento).ToShortDateString(),
                                emp.RFC,
                                emp.centroTrabajo!.noCentro,
                                emp.centroTrabajo.nombreCentro,
                                emp.centroTrabajo.ciudad,
                                emp.puesto!.numeroPuesto,
                                emp.puesto.puesto,
                                emp.puesto.descripcion,
                                emp.numCentroSupervisa,
                                emp.recibeCombustible == true ? "Si" : "No");
                    }
                    break;
                case EnumOpciones.Centros:
                    List<CentroTrabajo> listaCentros = conSql.ConsultaCentros();

                    foreach (CentroTrabajo cen in listaCentros)
                    {
                        this.dgvEmpleados.Rows.Add(
                                "",
                                "",
                                cen.noCentro,
                                cen.nombreCentro,
                                cen.ciudad);
                    }
                    break;
                default:
                    break;
            }
            
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmpleados.Columns["GridBtnModificar"].Index)
            {

                switch (opcionMenu)
                {
                    case EnumOpciones.Empleados:
                        using (FrmAltaEmpleados frmAltaEmpleado = new FrmAltaEmpleados(
                        new Empleado(
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
                        }
                        break;
                    case EnumOpciones.Directivos:
                        using (FrmAltaDirectivos frmAltaDirectivo = new FrmAltaDirectivos(
                        new Directivo(
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
                                                this.dgvEmpleados.Rows[e.RowIndex].Cells["des_puesto"].Value.ToString()),
                                        this.dgvEmpleados.Rows[e.RowIndex].Cells["num_centro_supervisa"].Value.ToString(),
                                        Convert.ToBoolean(this.dgvEmpleados.Rows[e.RowIndex].Cells["recibe_combustible"].Value.ToString().ToLower() == "no" ? 0 : 1)
                                        )))
                        {
                            frmAltaDirectivo.ShowDialog();
                        }
                        break;
                    case EnumOpciones.Centros:
                        using (FrmAltaCentros frmAltaCentros = new FrmAltaCentros(
                        new CentroTrabajo(
                                        this.dgvEmpleados.Rows[e.RowIndex].Cells["num_centro"].Value.ToString(),
                                        this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_centro"].Value.ToString(),
                                        this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_ciudad"].Value.ToString())))
                        {
                            frmAltaCentros.ShowDialog();
                        }
                        break;
                }

                this.dgvEmpleados.Rows.Clear();
                LlenaRegistrosGrid();

            }
            else if (e.ColumnIndex == dgvEmpleados.Columns["GridBtnEliminar"].Index)
            {
                switch (opcionMenu)
                {
                    case EnumOpciones.Empleados:
                        if (MessageBox.Show(string.Format("Estas apunto de eliminar el registro del empleado #{0} - {1}.\n¿estas seguro?", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value, this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_empleado"].Value.ToString())
                    , "Dar de baja empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (conSql.EjecutaNonQuery(string.Format("DELETE FROM cat_empleados WHERE num_empleado = {0}", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value)) == 1)
                            {
                                MessageBox.Show("Empleado dado de baja con exito", "Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dgvEmpleados.Rows.Clear();
                                LlenaRegistrosGrid();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error al intentar dar de baja al empleado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case EnumOpciones.Directivos:
                        if (MessageBox.Show(string.Format("Estas apunto de eliminar el registro del directivo #{0} - {1} por lo que pasará a ser empleado.\n¿estas seguro?", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value, this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_empleado"].Value.ToString())
                    , "Dar de baja empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (conSql.EjecutaNonQuery(string.Format("DELETE FROM directivos WHERE num_empleado = {0}", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value)) == 1)
                                if (conSql.EjecutaNonQuery(string.Format("UPDATE cat_empleados SET es_directivo = 0 WHERE num_empleado = {0}", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_empleado"].Value)) == 1)
                                {
                                    MessageBox.Show("Empleado dado de baja con exito", "Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.dgvEmpleados.Rows.Clear();
                                    LlenaRegistrosGrid();
                                }else
                                {
                                    MessageBox.Show("Ocurrio un error al intentar desmarcar como directivo al empleado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al intentar dar de baja al empleado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case EnumOpciones.Centros:
                        if (MessageBox.Show(string.Format("Estas apunto de eliminar el registro del centro #{0} - {1}.\n¿estas seguro?", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_centro"].Value, this.dgvEmpleados.Rows[e.RowIndex].Cells["nom_centro"].Value.ToString())
                    , "Dar de baja centro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (conSql.EjecutaNonQuery(string.Format("DELETE FROM cat_centros WHERE num_centro = {0}", this.dgvEmpleados.Rows[e.RowIndex].Cells["num_centro"].Value)) == 1)
                            {
                                MessageBox.Show("Centro dado de baja con exito", "Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dgvEmpleados.Rows.Clear();
                                LlenaRegistrosGrid();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error al intentar dar de baja al empleado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            }

            
        }
    }
}
