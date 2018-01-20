using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUpdateBtcBalance" in both code and config file together.
    [ServiceContract]
    public interface IUpdateBtcBalance
    {
        [OperationContract]
        double UpdateCurrentBtcBalance(string current_id, double current_btc, double additional_btc);
    }
}
