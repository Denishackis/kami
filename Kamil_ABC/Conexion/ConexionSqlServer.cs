using ProyectoKamil.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoKamil.Conexion
{
    internal class ConexionSqlServer
    {
        private SqlConnection? connection;
        string connectionString = "Server=localhost;Database=Kamil;Trusted_Connection=True;";

        public bool ProbarConexion()
        {
            bool respuesta = false;
            try
            {
                this.connection = new SqlConnection(connectionString);
                this.connection.Open();
                if (this.connection.State == ConnectionState.Open)
                {
                    respuesta = true;
                }
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message,"Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return respuesta;
        }

        private DataTable ConsultaDatos(string queryString)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(queryString, this.connection);
            adapter.Fill(dt);

            return dt;
        }

        public List<CentroTrabajo> ConsultaDatosCentro()
        {
            string queryString = "SELECT num_centro, nom_centro, nom_ciudad FROM cat_centros";

            List<CentroTrabajo> list = new List<CentroTrabajo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new CentroTrabajo(
                            reader["num_centro"].ToString()!, 
                            reader["nom_centro"].ToString()!, 
                            reader["nom_ciudad"].ToString()!
                            )
                        );
                }

                reader.Close();
            }

            return list;
        }

        public List<Puesto> ConsultaDatosPuesto()
        {
            string queryString = "SELECT num_puesto, nom_puesto, des_puesto FROM cat_puestos";

            List<Puesto> list = new List<Puesto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new Puesto(
                            reader["num_puesto"].ToString()!,
                            reader["nom_puesto"].ToString()!,
                            reader["des_puesto"].ToString()!
                            )
                        );
                }

                reader.Close();
            }

            return list;
        }

        public int EjecutaNonQuery(string queryString)
        {
            int registros = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                registros = command.ExecuteNonQuery();
            }
            return registros;
        }

        public List<Empleado> ConsultaEmpleados()
        {
            string queryString = @"SELECT  
                                     emp.num_empleado
                                    ,emp.nom_empleado
                                    ,emp.ape_paterno
                                    ,emp.ape_materno
                                    ,emp.fec_nacimiento
                                    ,emp.num_centro
                                    ,cen.nom_centro
                                    ,cen.nom_ciudad
                                    ,emp.num_puesto
                                    ,pue.nom_puesto
                                    ,pue.des_puesto
                                    FROM cat_empleados emp
                                    INNER JOIN cat_centros cen
                                    ON emp.num_centro = cen.num_centro
                                    INNER JOIN cat_puestos pue
                                    ON emp.num_puesto = pue.num_puesto;";

            List<Empleado> list = new List<Empleado>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(
                        new Empleado(
                            Convert.ToInt32(reader["num_empleado"]!),
                            reader["nom_empleado"].ToString()!,
                            reader["ape_paterno"].ToString()!,
                            reader["ape_materno"].ToString()!,
                            Convert.ToDateTime(reader["fec_nacimiento"]),
                            new CentroTrabajo(reader["num_centro"].ToString()!, reader["nom_centro"].ToString()!, reader["nom_ciudad"].ToString()!),
                            new Puesto(reader["num_puesto"].ToString()!, reader["nom_puesto"].ToString()!, reader["des_puesto"].ToString()!)
                            )
                        );
                }

                reader.Close();
            }

            return list;
        }
    }
}
