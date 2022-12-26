using System.Data.SqlClient;

namespace coursework_SQL
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JIA7CA9;Initial Catalog=shopBD;Integrated Security=True");

        public void openConnection() {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
