using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // User details

            //var firstName = "Radu";
            //string lastName = "Flitar";
            //var city = "Brasov";
            //int age = 31;
            //string address;

            //Console.WriteLine(" \nEnter your name:");
            //firstName = Console.ReadLine();
            //Console.WriteLine(" \nEnter your lastname: ");
            //lastName = Console.ReadLine();

            //Console.WriteLine(" \nEnter your city:  ");
            //city = Console.ReadLine();

            //Console.WriteLine(" \nEnter your age:  ");
            //age = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" \nEnter your address:  ");
            //address = Console.ReadLine();

            //// Output values

            //Console.WriteLine("====================================");
            //Console.WriteLine("========= User details: ============");
            //Console.WriteLine("====================================");

            //Console.WriteLine($"Name: {firstName} {lastName}");
            //Console.WriteLine($"Age: {age}");
            //Console.WriteLine($"City: {city}");
            //Console.WriteLine($"Address: {address}");

            //Console.ReadKey();

            // Exrcise 2

            string firstName;
            string lastName;
            string secondLastName = "radu";

            Console.WriteLine(" Enter your name:");
            firstName = Console.ReadLine();
            Console.WriteLine(" \nEnter your lastname: ");
            lastName = Console.ReadLine();

            // Compare strings

            Console.WriteLine(firstName.CompareTo(secondLastName));


            Console.ReadKey();



        }
    }
}
