using System;
namespace CircleRadius.CircleShape
{
    static void Main()
    {
        CircleRadius small;
        small = new CircleRadius();
        small.radius = 10;
        Console.WriteLine($"The radius is {small.radius}, radius is {small.CalculateArea()}");
    }
}