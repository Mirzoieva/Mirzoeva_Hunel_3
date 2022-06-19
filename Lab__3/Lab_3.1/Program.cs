using System;
using System.Collections.Generic;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = new List<int>();
            
            Random random = new Random();
            listOfInt.Add(random.Next(-100, 100));
            listOfInt.Add(random.Next(-100, 100));
            listOfInt.Add(random.Next(-100, 100));
            listOfInt.Add(random.Next(-100, 100));
            listOfInt.Add(random.Next(-100, 100));
            listOfInt.Add(random.Next(-100, 100));

            print(listOfInt);

            Console.WriteLine("Sort...");
            sort(listOfInt);

            Console.WriteLine("Sorted list:");
            print(listOfInt);

            Console.ReadLine();
        }

        static void sort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1] < list[j] && !((list[j - 1] > 0 && list[j] > 0) || ((list[j - 1] < 0 && list[j] < 0))))
                    {
                        list[j - 1]=list[j-1]+ list[j];
                        list[j] = list[j] - list[j - 1];
                        list[j] = -list[j];
                        list[j-1] = list[j-1]- list[j];
                    }
                }
            }
        }

        static void print(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
