using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main()
    {
        PrintName("Preethi", 10);

    }
    static void PrintName(string userName, int number)
    {
        for (int i = 0; i < number; i++)
        {
            {
                Console.WriteLine(userName, number);
                //PrintName(userName, number);
            }
        }

        // Console.WriteLine(userName, number);
    }
}