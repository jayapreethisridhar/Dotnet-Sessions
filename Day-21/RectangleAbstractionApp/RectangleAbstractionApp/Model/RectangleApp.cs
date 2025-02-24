using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace RectangleAbstractionApp.Models
    {
        class RectangleApp
        {
            public int height; //if we use public we can use the fields out of the class
            public int width;
            public int CalculatedArea()
            {
                return height * width;
            }
        }
    }

