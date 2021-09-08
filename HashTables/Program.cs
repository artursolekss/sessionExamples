using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable table = new Hashtable();
            // table.Add("Key1", "Value1");
            // table.Add("Key2", "Value2");
            // table.Add("Key3", "Value3");
            // foreach (var entry in table.Keys)
            // {
            //     Console.WriteLine(entry);
            // }
            Dictionary<String, String> table = new Dictionary<String, String>();
            // Hashtable table = new Hashtable();
            table.Add("Key2", "Value2");
            table.Add("Key1", "Value1");
            table.Add("Key3", "Value3");
            table.Add("Key4", "Value2");
            table.Add("Key5", "Value3");
            table.Add("Key6", "Value3");
            table.Add("Key7", "Value3");
            table.Add("Key8", "Value3");
            table.Add("Key9", "Value3");
            foreach (var entry in table.Keys)
            {
                Console.WriteLine(entry);
            }

        }
    }
}
