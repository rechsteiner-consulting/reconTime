using ReconTime.TimestampsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReconTime.TimestampsDataSet;

namespace ReconTime
{
    /// <summary>
    /// handles login or logout. The Login / LogoutMethode are set as follows:
    /// 0: By this application
    /// 1: - 3 TBD
    /// 4: An error was found (e.g. user has not logged out.) Default value 12:00 at the loginday was set.
    /// 5: User has not been logged out yet.
    /// </summary>
    class TimeWriter
    {
        public Boolean CheckIn(DateTime timestamp, int barcode)
        {   TimestampsTableAdapter adapter = new TimestampsTableAdapter();
            //überprüfe ob der Benutzer bereits angemeldet ist. Falls ja, logge ihn aus und erneut ein:
            TimestampsDataTable dt = adapter.GetData();
            string expression = "EmployeeID = " + barcode + " and CheckOutMethode = 5";

            if (dt.Select(expression).Length > 0)
            {
                CheckOut(timestamp, barcode);
            }

            try
            {
                adapter.Insert(timestamp, null, 0, 5, barcode);
                return true;
            } catch (SqlException e)
            {
                return false;
            }

        }
        public void CheckOut(DateTime timestamp, int barcode)
        {
            TimestampsTableAdapter adapter = new TimestampsTableAdapter();
            TimestampsDataTable dt = adapter.GetData();
            string expression = "EmployeeID = " + barcode + " and CheckOutMethode = 5";
            DataRow[] foundRows;

            // Use the Select method to find all rows matching the filter.
            foundRows = dt.Select(expression);
            
            foreach (DataRow row in foundRows){
                DateTime logIn;
                DateTime.TryParse(row[0].ToString(), out logIn);
                if (logIn.Day.Equals(DateTime.Now.Day))
                {
                    row[1] = DateTime.Now;
                    row[3] = 0;
                    adapter.Update(row);
                    Console.WriteLine(logIn);
                } else
                {
                    logIn = new DateTime(logIn.Year, logIn.Month, logIn.Day, 12, 0, 0);
                    row[1] = logIn;
                    row[3] = 4;
                    adapter.Update(row);
                    Console.WriteLine(logIn);
                }
            }               
        }

    }
}
