using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconTime
{
    class TimeWriter
    {
        private IDbConnection conn = new DbConnection().Conn;
        public void CheckIn(DateTime timestamp, int barcode)
        {   
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Timestamp (CheckIn, CheckOut, CheckInMethode, CheckOutMethode, EmployeeID)" +
                timestamp + ", 0, 0, 0, " + barcode;
            conn.Close();

        }
        public void CheckOut(DateTime timestamp, int barcode)
        {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Timestamp SET CheckOut='"+timestamp+"' WHERE EmployeeID='" + barcode + 
                "'AND MAX(CheckIn)";// /TODO replace xy
            conn.Close();

        }

    }
}
