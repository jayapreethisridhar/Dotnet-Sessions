using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmldeserializeLib.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }

       public Customer() 
        {
             Addresses = new List<Address>();   
        }
        //public void AddAddress(Address address)
        //{
        //    Addresses.Add(address);//validate address fields
        //}
            
            
    }
}
