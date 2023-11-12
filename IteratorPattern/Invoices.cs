using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Invoices : IIteratorCollection
    {
        public int DocNo { get; set; }
        public List<Item> items { get; set; } = new List<Item>();

        public IIterator CreateItemsIterator()
        {
            return new ItemsIterator(this);
        }

        public IIterator CreateReverseItemsIterator()
        {
            return new ReverseItemIterator(this);
        }
    }
}
