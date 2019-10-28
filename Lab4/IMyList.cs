using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface IMyList
    {
        void AddToList(MyList<OneEntry> list, object obj);
        void RemoveByName(MyList<OneEntry> list, string name);
        OneEntry FindByIndex(MyList<OneEntry> list, int index);
    }
}
