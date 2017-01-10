using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsole
{
    public class Subscriber
    {
        private string name;
        public Subscriber(string name, Contact publisher)
        {
            this.name = name;
            publisher.AddressChanged += HandleAddressChanged;
        }
        void HandleAddressChanged (object sender, AddressChangedEventArgs e)
        {
            Console.WriteLine("The address was changed from '" + e.OldAddress + "' to '" + e.NewAddress + "'");
        }
    }
}
