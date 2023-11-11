using System;
using System.IO;
using System.Security.Cryptography;


namespace SonarQubeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Example of hard-coded password (security vulnerability)
            string password = "admin123";

            // Example of an empty catch block (bad practice)
            try
            {
                File.ReadAllText("nonexistentfile.txt");
            }
            catch
            {
                // Empty catch block
            }

            // Example of unused method (code smell)
            UnusedMethod();
        }

        static string Generatecryptokey()
        {
            var random = new Random(); // Sensitive use of Random
            byte[] data = new byte[16];
            random.NextBytes(data);
            return BitConverter.ToString(data); // Check if this value is used for hashing or encryption
        }

        public void encrypt()
        {
            var simpleDES = new DESCryptoServiceProvider(); // Noncompliant
        }


        static void UnusedMethod()
        {
            Console.WriteLine("This method is never used.");
        }

        // Example of a method that should be static (code smell)
        public void ShouldBeStaticMethod()
        {
            Console.WriteLine("This method does not use instance data and should be static.");
        }
    }
}
