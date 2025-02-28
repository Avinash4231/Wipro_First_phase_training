using System;
using AcessSpecifierExample;

namespace ProgramAccessSpecifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleClass1 obj = new ConsoleClass1();

            obj.display();
        }
    }

    public class ConsoleClass1 : Class1   // Derived class
    {


        public void display()
        {

            //Console.WriteLine("derived class in another assembly "+Id); // You cannot access the private member in any of the derived  class
        }

    }

    public class ConsoleClass2  // Non- Derived class 
    {

        public void display()
        {


               //Console.WriteLine("Non-derived class in another assembly " + Id); // You cannot access the private member in any of the non-derived class

        }
    }
}

