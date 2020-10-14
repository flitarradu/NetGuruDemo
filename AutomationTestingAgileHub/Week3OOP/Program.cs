using System;

namespace Week3OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Curs cursulMeu = new Curs(1, "QAA", 48);

            //var cursulMeu2 = new Curs(2, "FrontEnt");

            var tutorial = new Tutorial();
            tutorial.SetCurs(1, "OOP", 2);

            Console.ReadKey();
        }
    }
}
