using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CSSerializeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bs = new Employee();

            XmlSerializer xs = new XmlSerializer(typeof(Employee));

            TextWriter txtWriter = new StreamWriter("d:\\Server\\Visual_studio\\Serialization.xml");

            xs.Serialize(txtWriter, bs);

            txtWriter.Close();

            using (FileStream fileStream = new FileStream("d:\\Server\\Visual_studio\\Serialization.xml", FileMode.Open))
            {
                Employee result = (Employee)xs.Deserialize(fileStream);
                Console.WriteLine(result.name);
            }

        }
    }
}
