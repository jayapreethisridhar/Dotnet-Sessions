using System;
class CommandlineHello
{
    static void Main(string[] userNames)
    {
        if(userNames.Length==0)
        {
            Console.WriteLine("No Arguments Passed, Please pass the arguments");
            return;
        }
        foreach(string name in userNames)
        {
            Console.WriteLine("Hi RRD folks!" + name);

        }
    }
}
