using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string>  name = new List <string> { "Olha", "Olena ", "Yana", "Vlad", "Maks", "Yulian" };            
            var firstletter =name.Select(l => l[0]).Reverse();
            foreach (var l in firstletter)
            {
                Console.WriteLine(l);
            } 
           
        } 
    }
}
