using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4
{
    public class MyListController : IMyList
    {
        private static string data_way = @"Data.txt";

        public void AddToList(MyList<OneEntry> list, object obj)
        {
            if (obj is OneEntry)
                list.Add((OneEntry)obj);
            else
                throw new System.ArgumentException("Parameter must be OneEntry's type",obj.GetType()+" "+obj.ToString());
        }
        public void RemoveByName(MyList<OneEntry> list, string name)
        {
            foreach (OneEntry item in list)
            {
                if (item.Name == name)
                {
                    list.Remove(item);
                    break;
                }
            }
        }
        public OneEntry FindByIndex(MyList<OneEntry> list, int index)
        {
            if (list.Count < index||index<0)
            {
                throw new System.IndexOutOfRangeException("Index is out of range"+" ("+index+") ");
             } 
            return list[index];
        }

        public void ReadFile(MyList<OneEntry> list)
        {
            list.Clear();
            string str=" ";
            string last = " ";
            int integer = 0;
            using (StreamReader sr = new StreamReader(data_way, System.Text.Encoding.Default))
            {
                while (!(str == null && last ==null))
                {
                    OneEntry entry = new OneEntry();
                    last = sr.ReadLine();
                    entry.Name = last;
                    str = sr.ReadLine();
                    if(int.TryParse(str,out integer))
                    {
                        entry.setValue(integer);
                    }
                    else
                    {
                        entry.setValue(str);
                    }
                    list.Add(entry);
                }
                sr.Close();
            }
        }

        public void WriteFile(MyList<OneEntry> list)
        {
            using (StreamWriter sr = new StreamWriter(data_way))
            {
                foreach(OneEntry item in list)
                {
                    sr.WriteLine(item.Name);
                    sr.WriteLine(item.getValue());
                }
            }
        }
    }
}
