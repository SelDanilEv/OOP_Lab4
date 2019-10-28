using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {            //       var 10
            //MyList<object> main = new MyList<object>();
            //MyList<object> notmain = new MyList<object>();
            //MyList<object>.Owner owner = new MyList<object>.Owner("Danil", 1, "DefCorp");
            //MyList<object>.MyDate date1 = new MyList<object>.MyDate();

            //Console.WriteLine("Info about Owner:");
            //Console.WriteLine(owner.GetInfo());
            //Console.WriteLine("Time:");
            //Console.WriteLine(date1.getTime());


            //MyList<object> myList = new MyList<object>() { "One", "Two", "Five" };
            //MyList<object> myList2 = new MyList<object>() { "Ten", "Eight", "Seven", "little" };
            //object MyName = "Danil";
            //main = MyName + myList;

            //Console.WriteLine("\nMyName + myList");
            //foreach (object str in main)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine("\nMyName --main");
            //main = --main;
            //foreach (object str in main)
            //{
            //    Console.WriteLine(str);
            //}

            //notmain = main;
            //Console.WriteLine("\n!=");
            //Console.WriteLine(notmain != main);

            //Console.WriteLine("\n==");
            //Console.WriteLine(notmain == main);

            //Console.WriteLine("\n*");
            //main = myList2 * myList;
            //foreach (object str in main)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine("\nExtensionMethod 1");
            //Console.WriteLine(ExtensionMethods.WordCount(main));


            //Console.WriteLine("\nExtensionMethod 2");
            //Console.WriteLine("\nmain");
            //Console.WriteLine(ExtensionMethods.CheckRepeat(main));
            //main = main * myList2;
            //Console.WriteLine("\nmain(2)");
            //Console.WriteLine(ExtensionMethods.CheckRepeat(main));

            //Console.WriteLine();
            //Console.WriteLine("Сумма всех элементов");
            //Console.WriteLine(StatisticOperation.sum(main));
            //Console.WriteLine("Разница в размерах");
            //Console.WriteLine(StatisticOperation.diff(main));
            //Console.WriteLine("Счетчик");
            //Console.WriteLine(StatisticOperation.count(main));


            //Console.WriteLine("Все ли буквы в слове маленькие?");
            //foreach(object item in main)
            //    Console.WriteLine( item.ToString()+' '+(item.whatWordInLowCase()).ToString());









            Rectangle<int> rectangle = new Rectangle<int>(4,"form","color" ,"border",1);
            Rectangle<string> rectanglestr = new Rectangle<string>("string","form","color" ,"border",1);
            Rectangle<bool> rectanglebool = new Rectangle<bool>( true,"form","color" ,"border",1);

            try
            {
                MyListController controller = new MyListController();
                MyList<OneEntry> main = new MyList<OneEntry>();

                //controller.ReadFile(main);


                OneEntry entry1 = new OneEntry("first", 15);
                OneEntry entry2 = new OneEntry("second", "32");
                OneEntry entry3 = new OneEntry("another entry", 19);
                OneEntry entry4 = new OneEntry("emptystr", "");
                OneEntry entrydefault = new OneEntry();

                object obj = new object();

                obj = 15;

                controller.AddToList(main, entry1);
                //controller.AddToList(main, obj);
                controller.AddToList(main, entry2);
                controller.AddToList(main, entry3);
                controller.AddToList(main, entry4);
                controller.AddToList(main, entrydefault);
                Console.WriteLine("\nMain :");
                foreach (OneEntry entry in main)
                {
                    Console.WriteLine(entry.Name + ' ' + (entry.getValue() ?? "Не найдено"));
                }

                controller.RemoveByName(main, "first");
                Console.WriteLine("\nRemote first :");
                foreach (OneEntry entry in main)
                {
                    Console.WriteLine(entry.Name + ' ' + (entry.getValue() ?? "Не найдено"));
                }

                Console.WriteLine("\nFind by index");
                OneEntry buffer = controller.FindByIndex(main, 2);
                Console.WriteLine(buffer.Name + ' ' + (buffer.getValue() ?? "Не найдено"));

                controller.WriteFile(main);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Конетс (после try)");
            }


            Console.ReadKey();
        }
    }

}
