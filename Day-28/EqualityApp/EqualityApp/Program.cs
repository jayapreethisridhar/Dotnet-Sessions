using System;
namespace EqualityApp.Model
{
    class Employee
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }
        private static void CaseStudy1()
        {
            var emp = new Employee(1, "Preethi", 30000);
            Console.WriteLine(emp);
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.GetType());
        }
        private static void CaseStudy2()
        {
            var venkat1 = new Employee(1, "venkat", 40000);
            var venkat2 = new Employee(2, "Venkat", 30000);
            Console.WriteLine(venkat1 == venkat2);

            var venkat3 = venkat1;
            Console.WriteLine(venkat3 == venkat1);
            Console.WriteLine(venkat1.Equals(venkat2));
        }
    }
}