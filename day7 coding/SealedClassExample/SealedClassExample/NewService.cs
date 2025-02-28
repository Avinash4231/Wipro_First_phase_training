using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public static class NewService
    {
        public static void Test3(this OldService ser)
        {

        }
        public static void Test4(this OldService ser, int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(ser.x);
        }
    }
}
