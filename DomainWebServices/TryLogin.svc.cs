using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;

namespace DomainWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TryLogin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TryLogin.svc or TryLogin.svc.cs at the Solution Explorer and start debugging.
    public class TryLogin : ITryLogin
    {
        public Dictionary<string, string> UserLogin(string username, string password)
        {
            Dictionary<string, string> retValue = new Dictionary<string, string>();

            GetUserIdReference.GetUserIdClient guic = new GetUserIdReference.GetUserIdClient();
            int userId = guic.GetExistingUserId(username, password);

            if (userId > 0)
            {
                
                retValue.Add("userId", userId.ToString());
                
            }

            else
            {
                retValue.Add("userId", "0");
            }



                return retValue;
            }




    }

}

