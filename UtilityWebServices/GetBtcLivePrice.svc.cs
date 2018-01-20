using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetBtcLivePrice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetBtcLivePrice.svc or GetBtcLivePrice.svc.cs at the Solution Explorer and start debugging.
    public class GetBtcLivePrice : IGetBtcLivePrice
    {
        public string DoWork()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp("https://www.bitstamp.net/api/ticker/");
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;
            request.Method = "GET";
            request.Timeout = 2000;

            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.Default);


            String data = readStream.ReadToEnd();



            int Start = data.IndexOf("\"last\": \"", 0) + 9;
            int End = data.IndexOf("\", \"timestamp\":", 0);

            String price = data.Substring(Start, End - Start);

            

            response.Close();
            readStream.Close();

            return price;
        }
    }
}
