using System;
using System.Collections.Generic;
using System.Collections;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection<string> collection = new UserCollection<string>();
            collection.ListCollection = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            collection.Add("Saturday");
            Console.ReadKey();
            collection.Remove();

            foreach (var element in collection)
                Console.WriteLine(element);
            Console.ReadKey();
            
            UserCollection<int> collection2 = new UserCollection<int>();
            collection2.ListCollection = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            collection2.Add(100);
            collection2.Add(200);
            collection2.Add(300);

            foreach (var element in collection2)
                Console.WriteLine(element);

            Console.ReadKey();
            
        }
    }
}