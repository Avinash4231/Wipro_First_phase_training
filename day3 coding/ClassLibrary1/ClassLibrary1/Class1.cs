using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Id = 20; // private access specifier 



        public void display()
        {

            Console.WriteLine(Id); // You can access the private member within that type 
        }
    }

    public class Class2 : Class1   // Derived class
    {

        public void display()
        {

            Console.WriteLine(Id); // You cannot access the private member in any of the derived  class
        }

    }

    public class Class3   // Non- Derived class 
    {

        public void display()
        {
            Class1 obj = new Class1();

            Console.WriteLine(obj.Id); // You cannot access the private member in any of the non-derived class

        }
    }
}

