using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;
using System.Linq;
//using System.Text.Json;
using System.IO;
namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(5, 2);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            
            using(FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lions.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, lion);

            }
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lions.dat", FileMode.OpenOrCreate))
            {
                Lion lion1 = (Lion)binaryFormatter.Deserialize(fs);
                Console.WriteLine(lion1.ToString());
            }

            string jsonSerializedString = JsonConvert.SerializeObject(lion);
            File.AppendAllText("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lions.json", jsonSerializedString);
            Console.WriteLine(JsonConvert.DeserializeObject<Lion>(jsonSerializedString).ToString());

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lion));
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lions.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, lion);
            }
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lions.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine(xmlSerializer.Deserialize(fs).ToString());
            }

            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsSoap.xml", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, lion);
            }
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsSoap.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine(soapFormatter.Deserialize(fs).ToString());
            }

            Lion[] lions = new Lion[] { new Lion(5, 2), new Lion(4, 3), new Lion(7, 1), new Lion(5, 3), new Lion(2, 2) };
            XmlSerializer xmlSerializerArr = new XmlSerializer(typeof(Lion[]));
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsArr.xml", FileMode.OpenOrCreate))
            {
                xmlSerializerArr.Serialize(fs, lions);
            }
            using (FileStream fs = new FileStream("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsArr.xml", FileMode.OpenOrCreate))
            {
                Lion[] lions1 = (Lion[])xmlSerializerArr.Deserialize(fs);
                foreach(var l in lions1)
                {
                    Console.WriteLine(l.ToString());
                }
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsArr.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode node in childnodes)
            {
                Console.WriteLine(node.OuterXml);
            }
            Console.WriteLine();

            XmlNodeList childnodes1 = xRoot.SelectNodes("Lion[age = '2']");
            foreach(XmlNode node in childnodes1)
            {
                Console.WriteLine(node.OuterXml);
            }
            Console.WriteLine();

            XDocument xdoc = XDocument.Load("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab14/lionsArr.xml");

            foreach (XElement l in xdoc.Element("ArrayOfLion").Elements("Lion"))
            {
                XElement posAttribute = l.Element("position");
                XElement ageElement = l.Element("age");

                if (posAttribute != null && ageElement != null)
                {
                    Console.WriteLine($"Position: {posAttribute.Value}");
                    Console.WriteLine($"Age: {ageElement.Value}");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
