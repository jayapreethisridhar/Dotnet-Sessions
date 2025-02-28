using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
     class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man is Playing Cricket");
        }

        public void Read()
        {
            Console.WriteLine("Man is Reading Books..");
        }
    }
}
