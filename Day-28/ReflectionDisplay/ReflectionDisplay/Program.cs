using System.Reflection;
using ReflectionDisplay.Models;

namespace ReflectionDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayName.DoReflection(typeof(Employee));
            DisplayName.DoReflection(typeof(Account));

        }
    }
}
