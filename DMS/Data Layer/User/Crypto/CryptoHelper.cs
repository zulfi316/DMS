using System;
using System.IO;
using System.Security.Cryptography;

namespace User.CryptoHelper
{
    class CryptoHelper
    {
        private static CryptoHelper _instance = null;

        public static CryptoHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CryptoHelper();
                }

                return _instance;
            }
        }

        RijndaelManaged rijndael;
        
        private CryptoHelper()
        {
            rijndael = new RijndaelManaged();
            // Generated random IV and Keys; This is AES 32-bit
            byte[] key = { 35, 228, 39, 125, 26, 46, 10, 110, 139, 190, 141, 168, 131, 195, 24, 142, 32, 135, 53, 166, 47, 119, 139, 250, 120, 70, 140, 187, 27, 107, 233, 165 };
            byte[] iv = { 230, 139, 3, 85, 221, 159, 45, 147, 252, 139, 46, 180, 173, 175, 142, 23 };

            rijndael.IV = iv;
            rijndael.Key = key;

        }

        public byte[] EncryptStringToBytes(string plainText)
        {
            // Declare the streams used
            // to encrypt to an in memory
            // array of bytes.
            MemoryStream msEncrypt = null;
            CryptoStream csEncrypt = null;
            StreamWriter swEncrypt = null;

            try
            {
                // Create a RijndaelManaged object
                // with the specified key and IV.

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

                // Create the streams used for encryption.
                msEncrypt = new MemoryStream();
                csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                swEncrypt = new StreamWriter(csEncrypt);

                //Write all data to the stream.
                swEncrypt.Write(plainText);

            }
            finally
            {
                // Clean things up.

                // Close the streams.
                if (swEncrypt != null)
                    swEncrypt.Close();
                if (csEncrypt != null)
                    csEncrypt.Close();
                if (msEncrypt != null)
                    msEncrypt.Close();
            }

            // Return the encrypted bytes from the memory stream.
            return msEncrypt.ToArray();

        }

        public bool ComparePassword(byte[] password, byte[] existingPassword)
        {
            bool result = false;

            if (password != null && existingPassword != null)
            {
                if (password.Length == existingPassword.Length)
                {
                    result = true;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] != existingPassword[i])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}