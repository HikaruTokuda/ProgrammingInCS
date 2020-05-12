using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// AES encryption
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_14
    {
        public static void DumpBytes(string title, byte[] bytes)
        {
            Console.WriteLine(title);

            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }


        public static void Listening3_14Main()
        {
            string plainText = "This is my super secret data";

            // byte array to hold the encrypted message
            byte[] cipherText;

            // byte array to hold the key that was used for encryption
            byte[] key;

            // byte array to hold the initialization vector that was used for encryption
            byte[] initializationVector;

            // Create am AES instance
            // This creates a random key and initialization vector
            using (Aes aes = Aes.Create())
            {
                // Copy the key and the initialization vector
                key = aes.Key;
                initializationVector = aes.IV;

                // create an encryptor to encrypt some data
                // should be wrapped in using for production code
                ICryptoTransform encryptor = aes.CreateEncryptor();

                // Create a new memory stream to receive the encrypted data
                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    // Create a CryptStream, tell it the stream to write to
                    // and encryptor to use. Also set the mode.
                    using (CryptoStream encryptCryptStream = new CryptoStream(encryptMemoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        // Make a streamwriter from the cryptstream
                        using (StreamWriter swEncrypt = new StreamWriter(encryptCryptStream))
                        {
                            // Write the secret message to the stream
                            swEncrypt.Write(plainText);
                        }
                        // Get the encrypted message from the stream
                        cipherText = encryptMemoryStream.ToArray();
                    }
                }
            }

            // Dump out our data
            Console.WriteLine("String to encrypt: {0}", plainText);
            DumpBytes("Key: ", key);
            DumpBytes("InitializationVector: ", initializationVector);
            DumpBytes("Encrypted: ", cipherText);

            Console.ReadKey();

            Listening3_15 decrypt = new Listening3_15(key, initializationVector, cipherText);
            decrypt.Listening3_15Main();
        }
    }
}

