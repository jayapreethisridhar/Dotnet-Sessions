using System;
using System.Reflection.Metadata.Ecma335;
class PrintNameRecursively
{
    static void Main()
    {
        //PrintName("Preethi",1);
        Console.Write("Enter a number to print how many times you want:");
        int number = int.Parse(Console.ReadLine());
        PrintName3(number);
    }
    static void PrintName(int number)
    {
        if (number <= 10)
        {
            Console.WriteLine($"Hi, I am Jayapreethi | {number}");
            number++;
            PrintName3(number);
        }

       // Console.WriteLine(userName, number);
    }
    static void PrintName2(int number)
    {
        if(number>0)
        {
            Console.WriteLine($"Hi, I am Jayapreethi | {number}");
            number--;
            PrintName2(number);
        }
    }
    static void PrintName3(int count)
    {
        if (count == 0)
        {
            return;
        }
        Console.WriteLine($"HI all i am {count}");
        PrintName3 (count-1);
    }
}