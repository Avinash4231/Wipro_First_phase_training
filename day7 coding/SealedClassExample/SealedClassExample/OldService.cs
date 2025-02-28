using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public sealed class OldService
    {
        public int x=50;
        public void Test1()
        {
            Console.WriteLine("Test1 method");
        }
        public void Test2()
        {
            Console.WriteLine("Test2 method");
        }
    }
}
