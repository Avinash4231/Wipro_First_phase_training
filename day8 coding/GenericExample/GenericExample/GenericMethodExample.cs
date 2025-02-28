using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class GenericMethodExample
    {
        
        public void GenericMethod<T1, T2>(T1 param, T2 param2)
        {
            Console.WriteLine($"Hello {param} from {param2}, you are welcome to join our community!");
        }
    }
}
