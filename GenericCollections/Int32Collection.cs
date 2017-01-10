using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GenericCollections
{
    class Int32Collection : Collection<int>
    {
        protected override void InsertItem(int index, int item)
        {
            Console.WriteLine("Inserting item {0} at position {1}", item, index);
            base.InsertItem(index, item);
        }
    }
}
