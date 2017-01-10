using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EventsConsole
{
    public class Contact
    {
        public event EventHandler<AddressChangedEventArgs> AddressChanged;
        public event EventHandler<AddressChangingEventArgs> AddressChanging;
        private string address;
        protected virtual void OnAddressChanged(AddressChangedEventArgs e)
        {
            EventHandler<AddressChangedEventArgs> handler = AddressChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public string Address
        {
            get { return this.address; }
            set
            {
                if (this.address != null)
                {
                    object old = this.address;
                    this.address = value;

                    AddressChangedEventArgs args = new AddressChangedEventArgs(old, this.address);
                    OnAddressChanged(args);
                }
                else
                {
                    
                    this.address = value;
                    AddressChangedEventArgs args = new AddressChangedEventArgs(this.address, this.address);
                    OnAddressChanged(args);
                }
                
            }
        }
    }
}
