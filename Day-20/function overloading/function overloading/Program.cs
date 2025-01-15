using System;
class Program
{
    static void Main()
    {
       
        PrintInfo(10);
        PrintInfo(10.55f);
        PrintInfo(10.55d);
        PrintInfo(10.55m);
        PrintInfo('A');
        PrintInfo('a');
    }
    static void PrintInfo(int input)
    {
        Console.WriteLine("overload int #1");
        Console.WriteLine(sizeof(int));
        Console.WriteLine("input value is: "+ input+ "and size is" + sizeof(int));
        Console.WriteLine("input value is: {0} and size is {1}", input, sizeof(int));
        Console.WriteLine($"input is value i {input} and int size is {sizeof(int)}");
    }
    static void PrintInfo(float input)
    {
        Console.WriteLine("Overload float #2");
        Console.WriteLine($"input is value i {input} and float size is {sizeof(float)}");
    }
    static void PrintInfo(double input)
    {
        Console.WriteLine("Overload double #3");
        Console.WriteLine($"input is value i {input} and double size is {sizeof(double)}");
    }
    static void PrintInfo(decimal input)
    {
        Console.WriteLine("Overload decimal #4");
        Console.WriteLine($"input is value i {input} and decimal size is {sizeof(decimal)}");
    }
    static void PrintInfo(char input)
    {
        Console.WriteLine("Overload float #5");
        Console.WriteLine($"input is value i {input} and float size is {sizeof(float)}");
        Console.WriteLine($"acii value is {(int)input}");
    }
}
    




