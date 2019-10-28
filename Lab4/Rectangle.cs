using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Rectangle<U>:Figure<U>
    {
        private string type = "Rectangle";
        

        public void GetMainInfo()
        {
            Console.WriteLine("Название: " + Name + "\nФорма: " + Form);
        }
        public override string ToString()
        {
            return "Тип:" + type + '\n' + ToConsoleFigure() +
                   '\n';
        }
        public override int GetHashCode()
        {
            int sum = 137;
            sum += type.GetHashCode();
            return sum;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            if (obj.GetHashCode() != GetHashCode())
                return false;
            return true;
        }

        public Rectangle() : base()
        {
            type = "Прямоугольник обыкновенный";
        }
        public Rectangle( U name, string form, string color, string border, int border_size)
            : base(name, form, color, border, border_size)
        {
            form = "Rectangle";
            type = "Прямоугольник но с параметрами";
        }
    }
}
