using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FoundationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDBConnection" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDBConnection.svc or GetDBConnection.svc.cs at the Solution Explorer and start debugging.
    public class GetDBConnection : IGetDBConnection
    {
        public string GetDBConnectionString()
            {
                string ConString = @"Server = localhost; Port = 3306; Database = bitcoinexhange; Uid = root; Pwd = 1234;";
        

                return ConString;

            }
     }
    
    
}
