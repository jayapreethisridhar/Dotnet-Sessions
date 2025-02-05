using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryApp.Models
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Name);
        }
        public override bool Equals(object other)
        {
            Customer second = (Customer)other;
            if (this.Id == second.Id && this.Name == second.Name)
            { 
                return true;
            }
                return false;
        }
        public override string ToString()
        {
            return $"id is {this.Id} name is {this.Name}";
        }
    }
}
