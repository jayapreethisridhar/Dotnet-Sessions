using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Model
{
    internal class ParentV2
    {
        private int _age;

        public ParentV2(int age)
        {
            _age = age;
            Console.WriteLine("Parent V2 created");
        }
        public int Age
        {
          get  { return _age; }
        }
    }
}
