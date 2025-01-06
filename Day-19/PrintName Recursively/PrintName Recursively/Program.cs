using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main()
    {
        PrintName("Preethi",1);
        
    }
    static void PrintName(string userName, int number)
    {
        if (number <= 10)
        {
            Console.WriteLine(userName, number);
            number++;
            PrintName(userName, number);
        }

       // Console.WriteLine(userName, number);
    }
}