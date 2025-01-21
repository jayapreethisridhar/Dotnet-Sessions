using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLapprogram.Model
{
    internal class Employees
    {
        private static int _lastId = 0;
        private static int _empId;
        private readonly string _name;
        
        //static Employees()
        //{
        //    Console.WriteLine("Static Constructor");
        //    Console.WriteLine("Called only once in entired project");
        //    _instanceCounter = 1000;
        //}
        public Employees(string name)
        {
            Console.WriteLine("Inside Constructor");
           // _employeeNumber = employeeNumber;
            _name = name;
            _empId = _lastId++;
        }
        
        
       
        public string Name
        {
            get { return _name; }
        }
        public int EmployeeID
        {
            get { return _empId; }
        }
        
    }
}
