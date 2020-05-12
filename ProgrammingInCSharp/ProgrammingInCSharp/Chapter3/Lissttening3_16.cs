using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/// <summary>
/// RSA encryptions
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Lissttening3_16
    {
        public static void Lissttening3_16Main()
        {
            string plainText = "This is my super secret data";
            Console.WriteLine("Plain text: {0}", plainText);

            // RSA works on byte arrrays, not strings og text
            // This will convert our input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();

            // Conveert the plain text into a byte array
            byte[] plainBytes = converter.GetBytes(plainText);
            Listening3_14.DumpBytes("Plain bytes: ", plainBytes);

            byte[] encryptedBytes;
            byte[] decryptedBytes;

            // Create a new RSA ro encrypt the data should be wrapped in using for production code
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();

            // get the keys out of the encryptor
            string publicKey = rsaEncrypt.ToXmlString(includePrivateParameters: false);
            Console.WriteLine("Public key: {0}", publicKey);
            string privateKey = rsaEncrypt.ToXmlString(includePrivateParameters: true);
            Console.WriteLine("Privatet key: {0}", privateKey);

            // Now tell the encryptor to use the public key to encryptthe data
            rsaEncrypt.FromXmlString(privateKey);

            // use the encryptor to encrypt the data. The f0AEP parameter
            // specifies how the output is "padded" with extra bytes
            // For maximum compatibility with receiving systems, set this as false
            encryptedBytes = rsaEncrypt.Encrypt(plainBytes, fOAEP: false);
            Listening3_14.DumpBytes("Encrypted bytes: ", encryptedBytes);

            // Now do the decoded - use the private key for this
            // We have sent someone our public key and they have used this to encrypt data that they are sending to us

            // Create a new RSA to decrypt the data
            // should be wrapped in using for production code
            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();

            // Configure the descryptor from the XML in the private key
            rsaDecrypt.FromXmlString(privateKey);
            decryptedBytes = rsaDecrypt.Decrypt(encryptedBytes, fOAEP: false);
            Listening3_14.DumpBytes("Decrypted bytes: ", decryptedBytes);

            Console.WriteLine("Decrypted string: {0}", converter.GetString(decryptedBytes));

            Console.ReadKey();

        }
    }
}
