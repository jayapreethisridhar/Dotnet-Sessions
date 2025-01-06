using System;
class Function
{
    static void Main()
    {
        PrintName("Jayapreethi", 5);
        bool result1 = CheckISEvenNoV2(10);
        Console.WriteLine($"CheckISEvenNoV1 result is {result1}");
        Console.WriteLine(CheckISEvenNoV1(13));
        Console.WriteLine(CheckISEvenNoV3(10));
        //Console.WriteLine(PrintName("Jaya",10));

        PrintTodayDate();

        string[] rrdFolks = GetAllRrdFolksNames();
        foreach (string name in rrdFolks)
        {
            Console.WriteLine(name);
        }

    }
    static string[] GetAllRrdFolksNames()
    {
        string[] folks = new string[5];
        folks[0] = "Preethi";
        folks[1] = "Shalini";
        folks[2] = "Venkat";
        folks[3] = "Sachin";
        folks[4] = "Deepa";

        //string[] folks = { "Preethi", "Shalini", "Venkat", "Sachin", "Deepa" };
        return folks;
    }
    static void PrintTodayDate()
    {
        Console.WriteLine(DateTime.Now.ToString("HH.mm"));
    }
    static bool CheckISEvenNoV1(int number)
    {
        if (number % 2 == 0)//modulus operator
        {
            return true;
        }
        return false;
    }
    static bool CheckISEvenNoV2(int number)
    {
        return (number % 2 == 0);
    }
    static string CheckISEvenNoV3(int number)
    {
        return (number % 2 == 0 ? "Its an even" : "Its an odd");
    }
    static void PrintName(string userName, int iterations)
    {
        for (int iteration = 1; iteration > iterations; iteration++)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iteration}");
        }
    }

}