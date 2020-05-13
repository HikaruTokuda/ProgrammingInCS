using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

/// <summary>
/// Signing data
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_20
    {
        public static void Listening3_20Main()
        {
            // This will converter our input string into byte and back
            ASCIIEncoding converter = new ASCIIEncoding();

            // Get a crypto provider out of the certificate store
            // should be wrapped in using for production code
            X509Store store = new X509Store("demoCertStore", StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            // should be wrapped in using for production code
            X509Certificate2 certificate = store.Certificates[0];

            // should be wrapped in using for production code
            RSACryptoServiceProvider encryptProvider = certificate.PrivateKey as RSACryptoServiceProvider;

            string messageToSign = "This is the message I want to sign";
            Console.WriteLine("Message: {0}", messageToSign);

            byte[] messageToSignBytes = converter.GetBytes(messageToSign);
            Listening3_14.DumpBytes("Messge to sign in bytes: ", messageToSignBytes);

            // need to calculate a hash for this message - this will go into the signatur and be used to verify the message
            // Create an omplementation of hashing algorithm we are going to use
            // should be wrapped in using for production code
            HashAlgorithm hasher = new SHA1Managed();
            // use the hasher to hash the message
            byte[] hash = hasher.ComputeHash(messageToSignBytes);
            Listening3_14.DumpBytes("Hash for message: ", hash);

            // Now sign the hash to create a signature
            byte[] signature = encryptProvider.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
            Listening3_14.DumpBytes("Signature: ", signature);

            // We can send the signature along with the message to authenticate it
            // Create a decryptor that uses the public key
            // should be wrapped in using for production code
            RSACryptoServiceProvider decryptProvider = certificate.PublicKey.Key as RSACryptoServiceProvider;

            // Now use the signature to perform a successful validation of the message
            bool validSignature = decryptProvider.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine("Correct signature validated OK: {0}", validSignature);

            // Change one byte of the signature
            signature[0] = 99;
            // Now try the using the incorrect signature to validate the message
            bool invalidSignature = decryptProvider.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine("Incorrect signature validated OK: {0}", invalidSignature);

            Console.ReadKey();

        }
    }
}
