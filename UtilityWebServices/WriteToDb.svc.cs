using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;


namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WriteToDb" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WriteToDb.svc or WriteToDb.svc.cs at the Solution Explorer and start debugging.
    public class WriteToDb : IWriteToDb
    {


        public void InsertPerson(Person info)
        {


            GetDBConnectionReference.GetDBConnectionClient gdbcc = new GetDBConnectionReference.GetDBConnectionClient();
            string conString = gdbcc.GetDBConnectionString();
            MySqlConnection db = new MySqlConnection(conString);
            db.Open();


            EncryptDataReference.EncryptDataClient dce = new EncryptDataReference.EncryptDataClient();
            string encpassword = dce.Encrypt(info.Password);

            string query = "insert into customer(username,password,email) VALUES (@Username,@Password,@Email)";


            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, db);
            cmd.Parameters.AddWithValue("username", info.Username);
            cmd.Parameters.AddWithValue("password", encpassword);
            cmd.Parameters.AddWithValue("email", info.Email);
            int result = cmd.ExecuteNonQuery();

            db.Close();




        }





    }
}
