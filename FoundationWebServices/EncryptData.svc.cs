using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace FoundationWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EncryptData" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EncryptData.svc or EncryptData.svc.cs at the Solution Explorer and start debugging.
    public class EncryptData : IEncryptData
    {
        public string Encrypt(string clearText)
        {


            string EncryptionKey = "test";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());

                }

            }
            return clearText;

        }
    }
}

