using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsyncApp.Services
{
    public class PrintService
    {
        public void Print() 
        {
            while (true)
            {
                Debug.WriteLine($"Date & Time {DateTime.Now.ToString("hh:mm:ss")}");
            }
        }
    }
}
