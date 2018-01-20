using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DomainWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetUserInfo" in both code and config file together.
    [ServiceContract]
    public interface IGetUserInfo
    {
        [OperationContract]
        Dictionary<string, string> GetUserInformation(int userId);

    }
}
