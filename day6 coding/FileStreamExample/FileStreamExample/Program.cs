using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string logDirectory = "Logs";
            //string logFile = Path.Combine(logDirectory, "user_log.txt");

            //if (!Directory.Exists(logDirectory))
            //{
            //    Directory.CreateDirectory(logDirectory);
            //}

            //Console.Write("Enter Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Age: ");
            //string age = Console.ReadLine();

            //Console.Write("Enter Email: ");
            //string email = Console.ReadLine();

            //string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //string logEntry = $"{timestamp} | Name: {name}, Age: {age}, Email: {email}";

            //File.AppendAllText(logFile, logEntry + Environment.NewLine);

            //Console.WriteLine("\nUser Logs:");
            //string[] logLines = File.ReadAllLines(logFile);
            //foreach (string line in logLines)
            //{
            //    Console.WriteLine(line);
            //}

            //CustomDefinedException.run();
            HRInterfaceProblem.run();
        }
    }
}
