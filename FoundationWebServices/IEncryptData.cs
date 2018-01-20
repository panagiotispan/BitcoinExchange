using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

using System.Text;

namespace FoundationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEncryptData" in both code and config file together.
    [ServiceContract]
    public interface IEncryptData
    {
        [OperationContract]
        string Encrypt(string clearText);
       
    }
}

