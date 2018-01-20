using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetUserId" in both code and config file together.
    [ServiceContract]
    public interface IGetUserId
    {
        [OperationContract]
        int GetExistingUserId(string username, string password);
    }
}
