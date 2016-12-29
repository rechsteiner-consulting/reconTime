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
        public void checkIn(DateTime timestamp, int barcode)
        {
            IDbCommand cmd = new EmployeeReader().connect().CreateCommand();
            cmd.CommandText = "INSERT INTO Timestamp (CheckIn, CheckOut, CheckInMethode, CheckOutMethode, EmployeeID) Values xy)";//TODO replace xy
        }

    }
}
