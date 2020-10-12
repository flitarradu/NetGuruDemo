using System;
using System.Collections;
using System.Collections.Generic;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste();
            Dictionare();

            ShowUserPassword("admin");
        }

        public static void Liste()
        {
            List<int> numerePrime = new List<int>();
            numerePrime.Add(1);
            numerePrime.Add(3);
            numerePrime.Add(5);
            numerePrime.Add(7);
            numerePrime.Add(13);

            foreach (var nrPrim in numerePrime)
                Console.WriteLine(nrPrim);

            List<string> orase = new List<string>();

            orase.Add("Brasov");
            orase.Add("Sanpetru");
            orase.Add("Fagaras");
            orase.Add("Sibiu");
            orase.Add("Cluj");

            foreach (string oras in orase)
                Console.WriteLine(oras);

            var arrayListExample = new ArrayList()
            {
                1, "Nume", true, 4.8, null
            };

            foreach (var element in arrayListExample)
                Console.WriteLine(element);



        }

        public static void ShowUserPassword( string myUser)
        {

            Dictionary<string, string> userDictionary = new Dictionary<string, string>();
            userDictionary.Add("admin", "parola1");
            userDictionary.Add("user1", "parola2");
            userDictionary.Add("user2", "parola3");

            foreach (var user in userDictionary)
            {
                if (user.Key.Equals(myUser))
                    Console.WriteLine($"Parola este: {user.Value}");
            }
        }

        public static void Dictionare()
        {
            SortedList<int, string> orase = new SortedList<int, string>();
            orase.Add(1, "Brasov");
            orase.Add(2, "Sibiu");
            orase.Add(3, "Iasi");
            orase.Add(4, "Fagaras");

            foreach (var oras in orase)
            {
                Console.WriteLine(oras);
            }


        }
    }
}
