using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var auth = new UserAuthentication(); // created an instance authentication
            var encryption = new DataEncryption(); //created an instance of encryption
            bool ex = true;
            while (ex)
            {
                Console.WriteLine("Welcome to the Secure Application!");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter username: ");
                        string registerUsername = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string registerPassword = Console.ReadLine();

                        Console.Write("Enter sensitive data to encrypt: ");
                        string sensitiveData = Console.ReadLine();

                        // Register user
                        auth.Register(registerUsername, registerPassword);

                        // Encrypt sensitive data
                        string encryptedData = encryption.Encrypt(sensitiveData);
                        Console.WriteLine("User registered successfully!");
                        Console.WriteLine($"Encrypted Sensitive Data: {encryptedData}");

                        // Store encrypted data for later use
                        Console.WriteLine("Remember your encrypted data: " + encryptedData);
                        break;

                    case "2":
                        Console.Write("Enter username: ");
                        string loginUsername = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string loginPassword = Console.ReadLine();

                        // Authenticate user
                        if (auth.Authenticate(loginUsername, loginPassword))
                        {
                            Console.Write("Enter encrypted data to decrypt: ");
                            string encryptedDataToDecrypt = Console.ReadLine();

                            // Decrypt sensitive data
                            try
                            {
                                string decryptedData = encryption.Decrypt(encryptedDataToDecrypt);
                                Console.WriteLine($"Decrypted Sensitive Data: {decryptedData}");
                            }
                            catch
                            {
                                Console.WriteLine("Invalid encrypted data.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;
                    case "3":
                        ex = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Exiting...");
                        break;
                }
            }
        }
    }
}
