using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ReconTime
{
    class DbConnection
    {
        private IDbConnection conn;
        public IDbConnection Conn
        {
            get { return conn; }
        }

        public DbConnection()
        {
            conn = Connect();
        }
        public IDbConnection Connect()
        {
            IDbConnection conn = new SqlConnection();
            conn.ConnectionString =
                    "Data Source=NBJS\\SQLEXPRESS;" + //TODO: DEBUG, change in real environment
                    "Initial Catalog=ReconTime;" +
                    "Integrated Security=SSPI;";
            conn.Open();
            return conn;
        }

        public void Close()
        {
            if (conn != null) // Verbindung schliessen
                conn.Close();
        }

    }

}