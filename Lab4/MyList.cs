using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class MyList<T> : List<T> where T : OneEntry
    {
        public class Owner
        {
            string name;
            int id;
            string organization;
            public Owner(string name, int id, string org)
            {
                this.name = name;
                this.id = id;
                this.organization = org;
            }

            public string GetInfo()
            {
                return $"{this.name} {this.id} {this.organization}\n";
            }
        }

        public class MyDate
        {
            DateTime date1;
            public MyDate()
            {
                date1 = DateTime.Now;
            }
            public DateTime getTime()
            {
                return date1;
            }
        }


        public static MyList<T> operator +(T b, MyList<T> a)
        {
            MyList<T> res = new MyList<T>();
            res.Add(b);
            foreach (T item in a) res.Add(item);
            return res;
        }

        public static bool operator ==(MyList<T> a, MyList<T> b)
        {
            bool flag = true;
            int sizea = 0;
            int sizeb = 0;
            foreach (T item in a)
            {
                sizea++;
            }
            foreach (T item in b)
            {
                sizeb++;
            }
            if (sizea != sizeb)
                return false;
            else
            {
                for (int q = 0; q < sizea; q++)
                {
                    if (a[q].Equals(b[q])) flag = false;
                }
                return flag;
            }
        }

        public static bool operator !=(MyList<T> a, MyList<T> b)
        {
            bool flag = true;
            int sizea = 0;
            int sizeb = 0;
            foreach (T item in a)
            {
                sizea++;
            }
            foreach (T item in b)
            {
                sizeb++;
            }
            if (sizea != sizeb)
                return true;
            else
            {
                for (int q = 0; q < sizea; q++)
                {
                    if (a[q].Equals(b[q])) flag = false;
                }
                return !flag;
            }
        }

        public static MyList<T> operator --(MyList<T> a)
        {
            MyList<T> res = new MyList<T>();
            bool i = false;
            foreach (T item in a)
                if (i)
                    res.Add(item);
                else i = !i;
            return res;
        }

        public static MyList<T> operator *(MyList<T> a, MyList<T> b)
        {
            MyList<T> res = new MyList<T>();
            foreach (T item in a) res.Add(item);
            foreach (T item in b) res.Add(item);
            return res;
        }
    }
}
