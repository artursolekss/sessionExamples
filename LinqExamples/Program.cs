using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "John", "James", "Ally", "Jimmy", "Roger" };
            //var jWords = from name in names where name[0] == 'J' select name;
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Jeniffer");
            names.AddLast("Jakcy");
            names.AddLast("Brian");
            names.AddLast("James");
            names.AddLast("Adam");

            IEnumerable<string> jWords = from name in names where name[0] == 'J' select name;
            foreach (var name in jWords)
                Console.WriteLine(name);

            Console.Write("\n");
            IEnumerable<string> longWords = from name in names where name.Length > 4 select name;
            foreach (var name in longWords)
                Console.WriteLine(name);
        }
    }
}
