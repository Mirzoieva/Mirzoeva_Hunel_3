using System;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Amount;
            int Number;

            Console.WriteLine("Введiть кiлькiсть елементiв словника:");
            Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть ключ, значення пiсля якого будуть виведенi: ");
            Number = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            Random random = new Random();

            for (int i = 0; i < Amount; i++)
            {
                dictionary.Add(i,random.Next(-100, 100));
            }
            for (int i = 0; i < Amount; i++)
            {
                Console.Write(dictionary[i] + " ");
            }
            Console.WriteLine();
        
            Console.WriteLine("Обранi елементи:");

            Dictionary<int, int> choosendictionary =sort(dictionary, Number);

            if (choosendictionary != null)
            {
                string str = JsonConvert.SerializeObject(choosendictionary);
                File.WriteAllText("Dictionary.json", str);

                Console.WriteLine("Iнформацiя з JSON файлу");
                Console.WriteLine(File.ReadAllText("Dictionary.json"));
            }

            Console.ReadLine();
        }
        static Dictionary<int,int> sort(Dictionary<int, int> keyValues, int Number)
        {
            Dictionary<int, int> choosendictionary = new Dictionary<int, int>();
            if (Number < keyValues.Count && Number >= 0)
            {
                foreach (KeyValuePair<int, int> el in keyValues)
                {
                    if (el.Key >= Number)
                    {
                        choosendictionary.Add(el.Key, el.Value);
                        Console.WriteLine("Key: " + el.Key + " Value: " + el.Value);
                    }

                }
                return choosendictionary;
            }
            else
            {
                Console.WriteLine("Такого ключа не iснує");
                return null;
            }
        }

}
}

