using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class OneEntry
    {
        public string Name;
        public int? valueint;
        public string valuestr;
        public void setValue(object obj)
        {
            valuestr = null;
            valueint = null;
            if (obj is string)
            {
                valuestr = "";
                valuestr = (string)obj;
            }
            if (obj is int)
            {
                valueint = (int)obj;
            }
            if(valuestr == null && valueint == null)
                Console.WriteLine("Указан неверный тип");
        }
        public OneEntry()
        {
            Name = "NoNameEntry";
        }
        public OneEntry(string name , object obj)
        {
            Name = name;
            setValue(obj);
        }
        public object getValue()
        {
            if (valuestr != null) return valuestr;
            if (valueint != null) return valueint;
            return null;
        }
    }
}

