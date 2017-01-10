using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ReconTime
{
    class EmployeeReader
    {
        public void Reader(String user, String password, String server)
        {
            IDbConnection conn = null;
            try
            {
                conn = new DbConnection().Conn;
                IDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select EmployeeID, LastName, FirstName FROM Employees";
                IDataReader reader = cmd.ExecuteReader();
                object[] dataRow = new object[reader.FieldCount];
                //----- Daten zeilenweise lesen und verarbeiten
                while (reader.Read())
                {
                    // solange noch Daten vorhanden sind
                    int cols = reader.GetValues(dataRow);
                    // tatsächliches Lesen
                    for (int i = 0; i < cols; i++) Console.Write("| {0} ", dataRow[i]);
                    Console.WriteLine();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                try
                {
                    if (conn != null) // Verbindung schliessen
                        conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        //TODO: Move to factory o.Ä.
    }

}