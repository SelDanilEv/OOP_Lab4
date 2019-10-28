using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class ExtensionMethods
    {
        public static int WordCount(this MyList<OneEntry> list)
        {
            int counter = 0;
            string chUp;
            string ch;
            foreach (OneEntry item in list)
            {
                chUp = item.Name.Substring(0, 1).ToUpper();
                ch = item.Name.Substring(0, 1);
                if (ch == chUp) counter++;
            }
            return counter;
        }

        public static bool CheckRepeat(this MyList<OneEntry> list)
        {
            int i = 0;
            int count = 0; ;
            foreach (OneEntry item1 in list)
            {
                count++;
                foreach (OneEntry item2 in list)
                {
                    if (item1 == item2) i++;
                }
            }
            if (i < count+1)
                return false;
            else return true;
        }
    }
}
