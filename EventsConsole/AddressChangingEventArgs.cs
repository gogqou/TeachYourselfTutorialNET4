using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsole
{
    public class AddressChangingEventArgs : EventArgs
    {
        private object data;
        public AddressChangingEventArgs(object data)
        {
            this.data = data;
        }
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

    }
}
