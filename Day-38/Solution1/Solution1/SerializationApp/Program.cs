using CustomerCommonLib;
using CustomerCommonLib.Model;
using System.Text.Json;

namespace Serialization
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SerializeToJson();
        }
        private static void SerializeToJson()
        {
            var c1 = new Customer { Id = 1, Name = "Preethi",
            Addresses = new List<Address> {
            new Address {City="Chennai",Country="India" },
            new Address {City="Delhi",Country="India"}
            }
            };
            var jsonString = JsonSerializer.Serialize(c1);
            Console.WriteLine(jsonString);
            var sw = new StreamWriter("C:\\Jayapreethi-html-app\\Dotnet-Sessions\\cust1.json");
            sw.WriteLine(jsonString);
            sw.Close();
            Console.WriteLine("Written to file");
        }
    }
}