
using System.Security.Principal;
using AccountCommonLib.Models;

namespace CustomExceptionHanlder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new Account(1001, "Minu", 5000);
            try
            {
                account.Withdraw(1000,account);//risky
            }
            catch (InsufficientFundsException ex)//ex expects object of Excpetion or subclasses of Exception
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            Console.WriteLine("End of main");
        }
    }
}
