using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "ERIRD", "Scott", "kendra" };
            names.Add("Maria");
            names.Add("Soma");
            names.Add("Soline");
            names.Remove("scott");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var index = names.IndexOf("kendra");
            Console.WriteLine($"Found kendra at index {index}");

            if (index == -1)
            {
                Console.WriteLine($"when an item is not found, Indexof returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
