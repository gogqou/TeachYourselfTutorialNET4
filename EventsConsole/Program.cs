using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            Subscriber sub1 = new Subscriber("sub1", contact);
            Subscriber sub2 = new Subscriber("sub2", contact);
        }
    }
}
