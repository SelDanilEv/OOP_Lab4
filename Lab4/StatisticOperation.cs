using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class StatisticOperation
    {

        public static string sum(MyList<OneEntry> list)
        {
            string sumstring = "";
            foreach (OneEntry item in list)
            {
                sumstring += item;
            }
            return sumstring;
        }

        public static int diff(MyList<OneEntry> list)
        {
            int min = int.MaxValue; int max = -1;
            //foreach (OneEntry item in list)
            //{
            //    if (item.Length < min) min = item.Length;
            //    if (item.Length > max) max = item.Length;
            //}
            //return max - min;
            return 0;
        }

        public static int count(MyList<OneEntry> list)
        {
            int counter = 0;
            foreach (OneEntry item in list)
                counter++;
            return counter;
        }

        public static bool whatWordInLowCase(this string word)
        {
            bool flag = true;
            char ch1;
            char ch2;
            for (int i =0; i < word.Length; i++)
            {
                ch1 = word[i];
                ch2 = word.ToLower()[i];
                if (ch1 != ch2) 
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

    }
}
