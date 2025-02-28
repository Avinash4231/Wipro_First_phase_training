using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    internal class AddMetaDataAttribute: Attribute
    {
        public string message { get; set; }
    public AddMetaDataAttribute(string message)
        {
            this.message = message;
        }
    }
}
