using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Iterator
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
