using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsole
{
    public class AddressChangedEventArgs:EventArgs
    {
        private object oldAddress;
        private object newAddress;

        public AddressChangedEventArgs(object old, object newAdd)
        {
            this.oldAddress = old;
            this.newAddress = newAdd;

        }
        public object OldAddress
        {
            get { return this.oldAddress; }

        }
        public object NewAddress
        {
            get { return this.newAddress; }
        }

    }
}
