using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_02
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> myList = new LinkedList<string>();

            myList.AddLast("1-A");
            myList.AddLast("2-B");
            myList.AddLast("3-C");
            myList.AddLast("4-D");
            myList.AddLast("5-E");
            myList.AddLast("6-F");
            myList.AddLast("7-G");
            myList.AddLast("8-H");
            myList.AddLast("9-I");
            myList.AddLast("10-J");

            // Т.к. удаление по индексу в LinkedList невозможно преобразуем LinkedList в массив строк 
            string[] myArr = new string[10];

            myList.CopyTo(myArr, 0);
            // номер элемента к-рый нужно удалить
            int del = 4;
            var query = myArr.Where(n => myArr.ElementAt(del) != n);
            Console.WriteLine(string.Join(" ", query.Select(x => x.ToString()).ToArray()));
            Console.ReadKey();


        }
    }
}
