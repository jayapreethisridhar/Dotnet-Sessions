﻿using CustomerCommonLib;
using CustomerCommonLibrary;
using System.Runtime.Serialization.Formatters.Binary;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Customer { Id = 1, Name = "Preethi" };
            c1.AddAddress(new Address { City = "Chennai", Country = "India" });

            var fs = new FileStream("C:\\temp\\cust1.bin", FileMode.Create);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            var binaryFormatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            binaryFormatter.Serialize(fs, c1);

            fs.Close();
            Console.WriteLine("object is serialzed");

        }
    }
}