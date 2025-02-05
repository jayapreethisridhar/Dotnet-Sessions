using XmldeserializeLib;
using mldeserializeLib.Model;
using System.Text.Json;

namespace XmldeserilaizeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("C:\\Jayapreethi-html-app\\Dotnet-Sessions\\Deserialization.xml");
            var xmlString = sr.ReadToEnd();

            Console.WriteLine(xmlString);

            XmlSerializer Serializer = new XmlSerializer(typeof(Customer));
            using (StringReader reader = new StringReader(xmlString))

                Customer customer = (Customer)Serializer.Deserialize(reader);

                Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
        }
    }
}