using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;



namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GetUsdBalance : IGetUsdBalance
    { 
        public double GetCurrentUsdBalance(int current_id)
        {
            double current_usd_balance = 0;

            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();
            string conString = gdbcc.GetDBConnectionString();
            MySqlConnection db = new MySqlConnection(conString);
            db.Open();

            string sql = "select usd_balance from customer where id = '" + current_id + "'";

            MySqlCommand query = new MySqlCommand(sql, db);
            MySqlDataReader queryResults = query.ExecuteReader();
            if (queryResults.Read())
            {
                current_usd_balance = queryResults.GetDouble(0);
            }
            queryResults.Close();
            queryResults = null;

            return current_usd_balance;
        }
    }
}
