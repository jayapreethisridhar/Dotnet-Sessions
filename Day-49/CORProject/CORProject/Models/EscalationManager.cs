using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORProject.Models
{

    public class EscalationManager : Handler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Request escalated to manager.");
        }
    }

}
