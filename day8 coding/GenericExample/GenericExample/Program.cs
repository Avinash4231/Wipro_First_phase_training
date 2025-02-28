using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyGenericClass<int> intobj = new MyGenericClass<int>(10);
            //int val=intobj.GenericMethod(200);
            //Console.WriteLine(val);

            //MyGenericClass<string> stringobj = new MyGenericClass<string>("ahuja");
            //string val = stringobj.GenericMethod("divya");
            //Console.WriteLine(val);

            // Using string for both name and address
            //var member1 = new GenericMethodExample();
            //member1.GenericMethod("John Doe", "New York");

            //// Using int for address (e.g., house number)
            //var member2 = new GenericMethodExample();
            //member2.GenericMethod("Alice", 101);


            // Using string for both name and address
            var member1 = new CommunityMember<string, string>("John Doe", "New York");
            member1.WelcomeMessage();

            // Using int for address (e.g., house number)
            var member2 = new CommunityMember<string, int>("Alice", 101);
            member2.WelcomeMessage();
        }
    }
}
