using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace DomainWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetUserInfo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetUserInfo.svc or GetUserInfo.svc.cs at the Solution Explorer and start debugging.
    public class GetUserInfo : IGetUserInfo
    {
        public Dictionary<string, string> GetUserInformation(int userId)
        {

            Dictionary<string, string> retValue = new Dictionary<string, string>();
            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();

            try
            {
                string conString = gdbcc.GetDBConnectionString();
                MySqlConnection db = new MySqlConnection(conString);
                db.Open();

                string sql = "SELECT * FROM customer WHERE id=" + userId;
                MySqlCommand query = new MySqlCommand(sql, db);
                MySqlDataReader queryResults = query.ExecuteReader();

                if (queryResults.Read())
                {
                    string username = queryResults.GetString(1);
                    string password = queryResults.GetString(2);
                    string email = queryResults.GetString(3);
                    string usd_balance = queryResults.GetString(4);
                    string bitcoins_balance = queryResults.GetString(5);

                    DecryptDataReference.DecryptDataClient dcee = new DecryptDataReference.DecryptDataClient();
                    string decpassword = dcee.Decrypt(password);

                    retValue.Add("username", username);
                    retValue.Add("password", decpassword);
                    retValue.Add("email", email);
                    retValue.Add("usd_balance", usd_balance);
                    retValue.Add("bitcoins_balance", bitcoins_balance);
                }
                else
                {
                    retValue.Add("username", "0");
                }
                queryResults.Close();
                queryResults = null;


                return retValue;
            }
            catch (Exception)
            {
                retValue.Add("username", "-1");
                return retValue;
            }

        }
        }
}
