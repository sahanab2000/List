using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doListDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDeno");
            //Creating List
            List<string> list = new List<string>(); //Adding object to the list
            list.Add("Arya");
            list.Add("Rushank");
            list.Add("Sparsha");
            list.Add("Samagna");

            // Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}

