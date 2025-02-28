
using OCPSolution.Models;

namespace OCPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit(101, "Preethi", 100000, 10, FestivalType.DIWALI);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}
