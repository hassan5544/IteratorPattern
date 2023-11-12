using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ItemsIterator : IIterator
    {

        private readonly Invoices _invoice;
        private int _currentIndex;

        public ItemsIterator(Invoices invoices)
        {
            _invoice = invoices;
        }
        public void First()
        {
            _currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _invoice.items.Count();
        }

        public void Next()
        {
            _currentIndex ++;
        }
        public Item Current()
        {
            return _invoice.items[_currentIndex];
        }

    }
}
