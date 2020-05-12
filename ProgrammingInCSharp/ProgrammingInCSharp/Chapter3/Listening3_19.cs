using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_19
    {
        public static void Listening3_19Main()
        {
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "Machine Level Key";

            // Specify that the key is to be stored in the machine level key store
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;

            // Create a crypto service provider
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParams);
            Console.WriteLine(rsa.ToXmlString(includePrivateParameters: false));

            // Make sure that it is persisting keys
            rsa.PersistKeyInCsp = true;
            // Clear the provider to make sure that it is saves the key.
            rsa.Clear();

        }
    }
}
