using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/// <summary>
/// RSA key management
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_17
    {
        public static void Listening3_17Main()
        {
            string containerName = "MyKeyStore";

            CspParameters csp = new CspParameters();
            csp.KeyContainerName = containerName;

            // Create a new RSA to encrypt the data
            RSACryptoServiceProvider rsaStore = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Stored keys: {0}", rsaStore.ToXmlString(includePrivateParameters: true));

            RSACryptoServiceProvider rsaLoad = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Loaded keys: {0}", rsaLoad.ToXmlString(includePrivateParameters: true));

            Console.ReadKey();
        }
    }
}
