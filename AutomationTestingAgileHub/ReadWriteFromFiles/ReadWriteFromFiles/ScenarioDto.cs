using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReadWriteFromFiles
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }
        public List<string> Values { get; set; }

        public static void WriteXML()
        {
            ScenarioDto myScenario = new ScenarioDto();

            myScenario.TestCaseName = "Scenariul1";
            myScenario.TestInput = "radu.flitar@gmail.ro";
            myScenario.OtherInfo = "password123";
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));

            var path = @"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteInXML.xml";

            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, myScenario);

            file.Close();
        }

        //public static ScenarioDto ReadXML()
        //{
        //    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));

        //    var path = @"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteInXML.xml";

        //    System.IO.StreamReader file = new System.IO.StreamReader(path);

        //    ScenarioDto myScenarioDto = (ScenarioDto)reader.Deserialize(file);

        //    file.Close();

        //    return myScenarioDto;
        //}

        public static void JsonSerialize()
        {
            ScenarioDto myObject = new ScenarioDto
            {
                TestCaseName = "Testcase1",
                TestInput = "Inputul meu",
                OtherInfo = "Alte informatii",
                Values = new List<string> { "value1", "value2", "value3" }

            };



            //string myJson = JsonConvert.SerializeObject(myObject, Formatting.Indented);

            //File.WriteAllText(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\ReadWriteFromFiles\MyJsonExample.json", JsonConvert.SerializeObject(myObject, Formatting.Indented));
            using(StreamWriter file=File.CreateText(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\ReadWriteFromFiles\MyJsonExample2.json"))
            {
                JsonSerializer serializator = new JsonSerializer();
                serializator.Serialize(file, myObject);          
            
            }
            Console.WriteLine("Fisierul json a fost creat");
        
        }

        public static void JsonDeserialize()
        {
            string myJson = @"{'TestCaseName': 'Testcase1', 'TestInput': 'Inputul meu', 'OtherInfo': 'Alte informatii'}";

            ScenarioDto myObject = JsonConvert.DeserializeObject<ScenarioDto>(myJson);

            Console.WriteLine(myObject.TestCaseName);
        }

        public static List<ScenarioDto> LoadValuesFromJsonFIle()
        {
            var myFile = @"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\ReadWriteFromFiles\MyJsonExample2.json";

            try {
                using (var reader= new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<ScenarioDto>>(config);

                    return myTestDataList;
                }
            
            }
            catch (Exception)
            {
                throw new Exception($"There is a problem with file {myFile}");            
            }
        
        }

    }
}
