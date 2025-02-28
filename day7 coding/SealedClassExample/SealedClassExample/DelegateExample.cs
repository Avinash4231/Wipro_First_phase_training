using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class DelegateExample
    {
        public delegate void PrintDelegate();
        public delegate void Operations(int a,int b);
        public delegate void PrintDelegate2(int result);


        public static void run()
        {
            //PrintDelegate pd = new PrintDelegate(printData);
            //pd();

            //Multi Delegate
            //Operations op = new Operations(Add);
            //op += new Operations(Subtract);
            //op(5, 4);

            PrintDelegate2 pd2 = new PrintDelegate2(showData);
            pd2(7);
            Subtract(5, 4, pd2);
        }

        public static void printData()
        {
            Console.WriteLine("Delegate associated Method has been called :");
        }

        public static void Add(int a,int b)
        {
            Console.WriteLine("the addition on two number is "+(a+b));
        }
        public static void Subtract(int a, int b, PrintDelegate2 pd)
        {
            Console.WriteLine("the subtraction on two number is " + (a - b));
        }
        public static void showData(int result)
        {
            Console.WriteLine("the result is " + result);
        }
    }
}
