using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCommonLib.Models
{
    public class Calculator
    {
        public long CubeEvenNo(int no)
        {
            if(!IsEven(no))
              throw new Exception(NotAnEvenNumberException(no));
            else
                return no*no*no;
        }
        private bool IsEven(int no)
        {
            return no%2 == 0;
        }
    }
}
