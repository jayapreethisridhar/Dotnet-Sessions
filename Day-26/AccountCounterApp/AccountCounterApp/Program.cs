using System;
using System.Security.Principal;
using AccountCounterApp.Model;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //static Property
           Console.ForegroundColor = ConsoleColor.Yellow;
            var venkat = new Account(101, "venkat", 2000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);
            Console.ResetColor();  // static Method

            new Account(102, "Minu", 3000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            new Account(103, "venkat", 4000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.WriteLine(Account.HeadCount);
        }
    }
}