using CustomerCommonLib;
using CustomerCommonLib.Model;
using System.Text.Json;

namespace DeserializaitonConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("C:\\Jayapreethi-html-app\\Dotnet-Sessions\\cust1.json");
            var jsonString = sr.ReadToEnd();

            Console.WriteLine(jsonString);

            var customer = JsonSerializer.Deserialize<Customer>(jsonString);

            Console.WriteLine("dserialized customer :" + customer.Name);
            Console.WriteLine("found address " + customer.Addresses.Count);
        }
    }
}