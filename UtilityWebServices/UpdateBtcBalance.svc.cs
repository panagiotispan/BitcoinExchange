using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;


namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UpdateBtcBalance" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UpdateBtcBalance.svc or UpdateBtcBalance.svc.cs at the Solution Explorer and start debugging.
    public class UpdateBtcBalance : IUpdateBtcBalance
    {
        public double UpdateCurrentBtcBalance(string current_id, double current_btc, double additional_btc)
        {

            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();
            string conString = gdbcc.GetDBConnectionString();
            MySqlConnection db = new MySqlConnection(conString);
            db.Open();

            double final_btc_balance = current_btc + additional_btc;

            string query = "update customer SET btc_balance=@final_btc_balance Where id = @current_id";


            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, db);
            cmd.Parameters.AddWithValue("final_btc_balance", final_btc_balance);
            cmd.Parameters.AddWithValue("current_id", current_id);
            int result = cmd.ExecuteNonQuery();

            db.Close();


            return final_btc_balance;

        }
    }
}
