﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionCircleApp.CircleShape
{
    class Circle
    {
        public float radius;
        public float calculateArea()
        {
            return 3.14f * radius * radius;
        }

    }
}
