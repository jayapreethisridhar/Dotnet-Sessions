using System;
class Function
{
    static void Main()
    {
        //PrintNames("Jayapreethi", 10);
        bool result1 = CheckISEvenNoV2(10);
        CheckISEvenNoV1(15);
        string resultOutsideFunction = CheckISEvenNoV3(10);
        //PrintTodayDate();
        string[] names = GetAllRrdFolksNames();
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(resultOutsideFunction);
        //Console.WriteLine($"CheckISEvenNoV1 result is {result1}");
        Console.WriteLine(CheckISEvenNoV3(13));
        Console.WriteLine(CheckISEvenNoV2(10));
        Console.WriteLine($"The name is even: {result1}");
        //Console.WriteLine(PrintName("Jaya",10));
    }
        //PrintTodayDate();

        //string[] rrdFolks = GetAllRrdFolksNames();
        //foreach (string name in rrdFolks)
        //{
        //    Console.WriteLine(name);
        //}

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
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.Now.ToString("HH.mm"));
    }
    static void PrintName(string userName, int iterations)
    {
        for (int i = 1; i <= iterations; i++)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iteration}");
        }
    }
static void CheckISEvenNoV1(int number)
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
   
}