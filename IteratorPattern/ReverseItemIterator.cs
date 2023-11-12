using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ReverseItemIterator : IIterator
    {

        private readonly Invoices _invoice;
        private int _currentIndex;

        public ReverseItemIterator(Invoices invoices)
        {
            _invoice = invoices;
        }
        public void First()
        {
            _currentIndex = _invoice.items.Count() - 1;
        }

        public bool HasNext()
        {
            return _currentIndex >= 0;
        }

        public void Next()
        {
            _currentIndex--;
        }
        public Item Current()
        {
            return _invoice.items[_currentIndex];
        }
    }
}
