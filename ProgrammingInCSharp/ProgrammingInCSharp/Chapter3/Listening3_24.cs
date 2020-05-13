using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// Encrypt a stream
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_24
    {
        public static void Listening3_24Main()
        {
            string plainText = "This is my super secret data";

            // bytea\ array to hold the encrypted message
            byte[] encryptedText;

            // byte array to hold the key that was used for encrypt
            byte[] key1;
            byte[] key2;

            // byte array to hold the initialization vector that was used for encryption
            byte[] initializationVector1;
            byte[] initializationVector2;

            using (Aes aes1 = Aes.Create())
            {
                // copy the key and the initialization vector
                key1 = aes1.Key;
                initializationVector1 = aes1.IV;

                // create an encryptor to encrypt some data
                ICryptoTransform encryptor1 = aes1.CreateEncryptor();

                // Create a new memory stream to receive the encrypted data
                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    // Create a crypto CryptoStream, tell it the stream to write to and the encryptor to use. Also set the mode
                    using (CryptoStream cryptoStream1 = new CryptoStream(encryptMemoryStream, encryptor1, CryptoStreamMode.Write))
                    {
                        // Add another layerof encryption
                        using (Aes aes2 = Aes.Create())
                        {
                            // copy the key and the initialization vector
                            key2 = aes2.Key;
                            initializationVector2 = aes2.IV;

                            ICryptoTransform encryptor2 = aes2.CreateEncryptor();

                            using (CryptoStream cryptoStream2 = new CryptoStream(cryptoStream1, encryptor2, CryptoStreamMode.Write))
                            {
                                using (StreamWriter swEncrypt = new StreamWriter(cryptoStream2))
                                {
                                    //Write te secret message to the stream
                                    swEncrypt.Write(plainText);
                                }

                                // get the encrypted essage from the stream
                                encryptedText = encryptMemoryStream.ToArray();
                                Console.WriteLine("encryptedText: ");
                                Console.WriteLine(encryptedText);
                                Console.ReadKey();
                            }
                        }

                    }
                }
            }
        }
    }
}
