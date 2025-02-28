using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORProject.Models
{
    
        public class Level2Support : Handler
        {
            public override void Handle(string request)
            {
                if (request.Contains("complex issue"))
                {
                    Console.WriteLine("Level 2 support handled the request.");
                }
                else
                {
                    base.Handle(request);
                }
            }
        }
    
}
