using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class CommunityMember<TName, TAddress>
    {
        private TName Name;
        private TAddress Address;

        public CommunityMember(TName name, TAddress address)
        {
            Name = name;
            Address = address;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine($"Hello {Name} from {Address}, you are welcome to join our community!");
        }
    }
}
