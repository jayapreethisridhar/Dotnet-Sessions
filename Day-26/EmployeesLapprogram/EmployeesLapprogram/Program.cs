
using System;
using System.Security.Principal;
using EmployeeLapprogram.Model;

namespace EmployeeLapprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //static prorperty
            Console.ForegroundColor = ConsoleColor.Red;

            var employee1 = new Employees("Preethi");
            var employee2 = new Employees("Shalini");
            var employee3 = new Employees("Venkat");


            Console.WriteLine("Employee1 Id:" + employee1.EmployeeID);
            Console.WriteLine("Employee2 Id:" + employee2.EmployeeID);
            Console.WriteLine("Employee3 Id:" + employee3.EmployeeID);

        }

            
    }
}
