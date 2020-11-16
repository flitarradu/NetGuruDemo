using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFromFiles
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }

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

        public static ScenarioDto ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));

            var path = @"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteInXML.xml";

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            ScenarioDto myScenarioDto = (ScenarioDto)reader.Deserialize(file);

            file.Close();

            return myScenarioDto;
        }

    }
}
