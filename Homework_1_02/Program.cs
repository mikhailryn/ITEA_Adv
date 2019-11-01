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
                LinkedList<string> daysOfWeek = new LinkedList<string>();

                daysOfWeek.AddFirst("Monday");
                daysOfWeek.AddAfter(daysOfWeek.Last, "Tuesday");
                daysOfWeek.AddAfter(daysOfWeek.Last, "Wednesday");
                daysOfWeek.AddAfter(daysOfWeek.Last, "Thursday");
                daysOfWeek.AddAfter(daysOfWeek.Last, "Friday");

                string[] sArray = new string[daysOfWeek.Count];
                daysOfWeek.CopyTo(sArray, 0);

                int middle_idx = daysOfWeek.Count / 2;

                // Проходим одновременно по массиву и по коллекции
                Console.WriteLine("Первоначальный список\n");
                LinkedListNode<string> currentNode = daysOfWeek.First;
                for (int i = 0; i <= daysOfWeek.Count; i++)
                {
                    Console.WriteLine(sArray[i]);
                    if (i == middle_idx)
                    {
                        // Удаляем из коллекции узел, соответствующий элементу массива
                        daysOfWeek.Remove(currentNode);
                    }

                    if (currentNode != null) currentNode = currentNode.Next;
                }

                // Проверка
                Console.WriteLine("\nСписок после удаления среднего элемента\n");
                currentNode = daysOfWeek.First;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Next;
                }
            Console.ReadKey();


        }
    }
}
