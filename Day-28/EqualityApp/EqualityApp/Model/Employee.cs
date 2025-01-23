using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityApp.Model
{
    internal class Program
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _salary;

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }
        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; } 
        }
        public double Salary
        {
            get { return _salary; }
        }
    }
}
