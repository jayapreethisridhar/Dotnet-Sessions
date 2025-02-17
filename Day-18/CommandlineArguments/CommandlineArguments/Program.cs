using System;
class CommandlineArguments
{
    static void Main(string[] userNames)
    {
        if(userNames.Length==0)
        {
            Console.WriteLine("No arguments passed, Please pass the arguments");
            return;
        }
        Console.WriteLine("The names are in straight Line");
        for(int i = 0; i<userNames.Length;i++)
        {
            Console.WriteLine("Hi Welcome:" + userNames[i]);
        }
        Console.WriteLine("");
        Console.WriteLine("The names are in reverse order");
        for(int i = userNames.Length - 1; i >=0; i--)
        {
            Console.WriteLine("RRD Folks-->" + userNames[i]);
        }
    }
}

