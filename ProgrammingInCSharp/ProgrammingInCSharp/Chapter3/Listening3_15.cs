using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// AES descryption
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_15
    {
        byte[] cipherText;
        byte[] key;
        byte[] initializationVector;

        public Listening3_15(byte[] key, byte[] initializationVector, byte[] cipherText)
        {
            this.key = key;
            this.initializationVector = initializationVector;
            this.cipherText = cipherText;
        }

        public void Listening3_15Main()
        {
            // Now do the escryption
            string decryptedText;

            using (Aes aes = Aes.Create())
            {
                // Configure the aes instances write the key and initialization vector to use for the descryption
                aes.Key = key;
                aes.IV = initializationVector;

                // Create a decryptor from aes should be wwarapped in using for production code
                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream decryptStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream decryptCryptoStream = new CryptoStream(decryptStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(decryptCryptoStream))
                        {
                            // Read the decrypt bytes from the decrypting stream and place them in a string.
                            decryptedText = srDecrypt.ReadToEnd();
                            Console.WriteLine("DecryptedText: {0}", decryptedText);
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
