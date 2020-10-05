using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProj
{
    class Dictionaries
    {
        public static void DictionariesProblem()
        {
            //Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock. - 3 of type apple, 5 of type orange, 2 of type banana
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("apple", 3);
            inventory.Add("orange", 5);
            inventory.Add("banana", 2);

            Console.WriteLine(inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);
        }

    }
}
