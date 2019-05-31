using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BuyBtc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BuyBtc.svc or BuyBtc.svc.cs at the Solution Explorer and start debugging.
    public class BuyBtc : IBuyBtc
    {

        public double DoWork(double BtcAmountToBuy, string CurrentBtcPrice)
        {
            try
            {
                string btcprice = CurrentBtcPrice;
                double btcprice2 = double.Parse(btcprice, System.Globalization.CultureInfo.InvariantCulture);
                double result = BtcAmountToBuy * btcprice2;

                return result;
            }
            catch (Exception)
            {
                
                return 0;
            }
            
        }
    }
}
