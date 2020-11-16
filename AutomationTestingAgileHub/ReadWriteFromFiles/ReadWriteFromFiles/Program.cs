using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };

            ////System.IO.File.WriteAllLines(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt", lines);


            //string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ";

            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt", true) )
            //{
            //    foreach (var line in lines)
            //    {
            //        if(line.Contains("3"))
            //        {
            //            file.WriteLine(line);
            //        }

            //    }
            //}

            //string [] readLines = System.IO.File.ReadAllLines(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt");
            //string readText = System.IO.File.ReadAllText(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt");

            //foreach (var line in readLines)
            //{
            //    Console.WriteLine(line);
            //}

            //string line;
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt");

            //while ((line = file.ReadLine()) != string.Empty)
            //{
            //    Console.WriteLine(line);
            //}

            //file.Close();
            //System.IO.File.WriteAllText(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt", text);

           // ScenarioDto.WriteXML();

            var myScenario = ScenarioDto.ReadXML();

            Console.WriteLine($"Numele scenariului este {myScenario.TestCaseName}, numele proprieatii este {myScenario.TestInput}, numele proprietatii 3 este {myScenario.OtherInfo}");
            Console.ReadKey();
        }
    }
}
