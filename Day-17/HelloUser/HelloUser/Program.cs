using System;
class HelloUser
{
    static void Main()
    {
        Console.Write("Enter the number how many times you want to print");
        var Number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < Number; i++)
        {
            Console.WriteLine("Hello RRd user welocome to RRD");
        }
    }
}


