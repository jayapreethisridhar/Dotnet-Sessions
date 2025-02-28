using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORProject.Models
{
    
        public abstract class Handler
        {
            protected Handler next;

            public void SetNext(Handler handler)
            {
                next = handler;
            }

            public virtual void Handle(string request)
            {
                if (next != null)
                {
                    next.Handle(request);
                }
            }
        }
    
}
