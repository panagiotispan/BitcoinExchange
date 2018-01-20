using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;


namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UpdateUsdBalance" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UpdateUsdBalance.svc or UpdateUsdBalance.svc.cs at the Solution Explorer and start debugging.
    public class UpdateUsdBalance : IUpdateUsdBalance
    {

        public double UpdateCurrentUsdBalance(string current_id, double current_usd, double additional_usd)
        {

            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();
            string conString = gdbcc.GetDBConnectionString();
            MySqlConnection db = new MySqlConnection(conString);
            db.Open();

            double final_usd_balance = current_usd + additional_usd;

            string query = "update customer SET usd_balance=@final_usd_balance Where id = @current_id";


            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, db);
            cmd.Parameters.AddWithValue("final_usd_balance", final_usd_balance);
            cmd.Parameters.AddWithValue("current_id", current_id);
            int result = cmd.ExecuteNonQuery();

            db.Close();


            return final_usd_balance;

        }
    }
}
