using System.Drawing;

namespace RectangleAbstractionApp.Model
    class Program
{
    static void Main()
    {
        Rectangle small = new Rectangle();
        small.Width = 10;
        small.Height = 5;
        Console.WriteLine($"small width is {small.width}, heigth is {small.height}, area is {small.CalculateArea()}");

        Rectangle big = new Rectangle();
        big.Width = 10;
        big.Height = 5;
        Console.WriteLine($"big width is {big.width}, heigth is {big.height}, area is {big.CalculateArea()}");
    }
}