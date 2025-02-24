using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main()
    {
        PrintNameFunction("Preethi", 10);
        PrintNameUserInput();

    }
    static void PrintNameFunction(string name, int iteration)
    {
        for (int i = 0; i < iteration; i++)
        {
            
                Console.WriteLine($"Hi, I am {name.ToUpper()} ! Welcome{i}");
                //PrintName(userName, number);
            
        }

        // Console.WriteLine(userName, number);
    }
    static void PrintNameUserInput()
    {
        Console.Write("Enter your Name:");
        string userName = Console.ReadLine();
        Console.Write("Enter your Number of times to print you want:");
        int iteration = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i <= iteration; i++)
        {
            Console.WriteLine($"Hi i am {userName}! Welcome{i}");
        }
    }
}