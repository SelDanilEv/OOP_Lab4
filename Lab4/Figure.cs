using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Figure<T>
    {
        private T _name;
        private string _form;
        private string _color;
        private string _border;
        private int _border_size;
        public T Name { get { return _name; } }
        public string Form { get { return _form; } }
        public string Color { get { return _color; } }
        public string Border { get { return _border; } }
        public int Border_size { get { return _border_size; } }
        virtual public void WriteVoid()
        {
            Console.WriteLine("Virtual void in figure");
        }
        public Figure(T name, string form, string color, string border, int border_size)
        {
            Console.WriteLine(name.GetType());
            _name = name;
            _form = form;
            _color = color;
            _border = border;
            _border_size = border_size;
        }
        public Figure()
        {
            _form = "Not";
            _color = "Black";
            _border = "Solid";
            _border_size = 1;
        }
        public string ToConsoleFigure()
        {
            return "Фигура:\n" +
                   "\tНазвание: " + _name + "\n\tФорма: " + _form +
                   "\n\tЦвет: " + _color + "\t Рамка: " + _border +
                   "\n\tРазмер рамки: " + _border_size.ToString() + " px";
        }
        public override string ToString()
        {
            return "Фигура:\n" +
                   "\tНазвание: " + _name + "\n\tФорма: " + _form +
                   "\n\tЦвет: " + _color + "\t Рамка: " + _border +
                   "\n\tРазмер рамки: " + _border_size.ToString() + " px";
        }
    }
}
