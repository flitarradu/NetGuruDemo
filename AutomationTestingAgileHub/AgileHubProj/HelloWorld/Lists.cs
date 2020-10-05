using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProj
{
    class Lists
    {
        //Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.


        // test code
        public static void ListsProblem()
        {
            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
        }


    }
}
