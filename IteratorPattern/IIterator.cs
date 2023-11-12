using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface IIterator
    {
        void First();
        void Next();
        bool HasNext();
        Item Current();
    }
}
