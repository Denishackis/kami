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
    }
}
