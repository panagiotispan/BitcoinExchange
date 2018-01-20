using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWriteToDb" in both code and config file together.


   
    public class Person
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Email { get; set; }

    }



    [ServiceContract]
    public interface IWriteToDb
    {


        [OperationContract]
        void InsertPerson(Person info);
       
    }
}
