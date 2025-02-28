using System;
namespace AccountLapprogram.Models
{
    class Account
    {
        static void Main()
        {
            AccountObject account1 = new AccountObject(500234, "Jaya", "sdg@rrd.com", 10000);
            AccountObject account2 = new AccountObject(500235, "Shalini", "abc@rrd.com", 210000);
            AccountObject account3 = new AccountObject(500236, "Venkat", "efg@rrd.com", 30000);
            AccountObject account4 = new AccountObject(500237, "Sachin", "hjk@rrd.com", 5000);
            account1.Withdraw(5000);
            account2.Deposit(4000);

            AccountObject[] accounts = { account1, account2, account3, account4 };
            AccountObject.Transfer(account2, account1, 3000);
            PrintDetails(accounts);
        }
        public static void PrintDetails(AccountObject[] accounts)
        {
            foreach (AccountObject account in accounts)
            {
                Console.WriteLine(account.AccountNumber);
                Console.WriteLine(account.Name);
                Console.WriteLine(account.Email);
                Console.WriteLine(account.Balance);
                Console.ForegroundColor = ConsoleColor.Green;
                if (account.CheckRichestAccount)
                {
                    Console.WriteLine("Richest Holder");
                }
                if (account.CheckLargeName)
                {
                    Console.WriteLine("Largest Name");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}