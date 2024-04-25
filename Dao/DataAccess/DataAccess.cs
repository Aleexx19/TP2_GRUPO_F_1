using System;
using System.Data.SqlClient;

namespace Dao.DataAccessObject
{
    internal class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if(reader != null) reader.Close();
            connection.Close();
        }

    }
}
