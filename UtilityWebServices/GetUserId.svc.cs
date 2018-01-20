using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.IO;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetUserId" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetUserId.svc or GetUserId.svc.cs at the Solution Explorer and start debugging.
    public class GetUserId : IGetUserId
    {
        public int GetExistingUserId(string username, string password)
        {
            int userId = 0;


            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();
            string conString = gdbcc.GetDBConnectionString();
            MySqlConnection db = new MySqlConnection(conString);
            db.Open();

            EncryptDataReference.EncryptDataClient dcee = new EncryptDataReference.EncryptDataClient();
            string decpassword = dcee.Encrypt(password);

            string sql = "SELECT id FROM customer where username='" + username + "' AND password='" + decpassword + "'";
            


            MySqlCommand query = new MySqlCommand(sql, db);
            MySqlDataReader queryResults = query.ExecuteReader();
            if (queryResults.Read())
            {
                userId = queryResults.GetInt32(0);
                
            }
            queryResults.Close();
            queryResults = null;

            return userId;

        }
    }
}
