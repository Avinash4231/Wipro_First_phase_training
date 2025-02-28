using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    //hre T is the placeholder which specify the data type
    class MyGenericClass<T>
    {
        private T GenericVariable;
        public MyGenericClass(T value)
        {
            GenericVariable = value;
        }

        public T GenericMethod(T GenericParameterValue)
        {
            Console.WriteLine($"Type of Data is: {typeof(T)}");
            return GenericVariable;
        }
        public T GenericProperty { get; set; }
    }
}
