using System;


namespace HelloWorldProj
{
    class Program
    {
        static void Main(string[] args)
        {

            // learncs.org
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Conditionals:");
            Conditionals.ConditionalsProblem();

            Console.ReadKey();
            Console.WriteLine("Arrays:");
            Arrays.ArraysProblem();

            Console.ReadKey();
            Console.WriteLine("Lists:");
            Lists.ListsProblem();

            Console.ReadKey();
            Console.WriteLine("Dictionaries:");
            Dictionaries.DictionariesProblem();

            Console.ReadKey();
            Console.WriteLine("Strings:");
            Strings.StringsProblem();

            Console.ReadKey();
            Console.WriteLine("For Loops:");
            ForLoops.ForLoopsProblem();

            Console.ReadKey();
            Console.WriteLine("While Loops:");
            WhileLoops.WhileLoopsProblem();

            Console.ReadKey();
            Console.WriteLine("Methods:");
            Console.WriteLine(Methods.foo(4,2));

            Console.ReadKey();
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Console.WriteLine(car1.numTires);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.runs);

            Console.ReadKey();
            Vehicle car = new Vehicle( "car", 4, 2000, true);
            Vehicle oldcar = new Vehicle("car", 4, 1980, false);
            Vehicle bike = new Vehicle("bike", 2, 2017, true);

            Console.WriteLine(car.Type);
            Console.WriteLine(oldcar.Runs);
            Console.WriteLine(bike.NumTires);
        }
    }
}
