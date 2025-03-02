﻿using DIPConsoleVoilationApp.LowLevel;
using TaxCommonLib.HighLevel;

namespace TaxCalcInfraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator   (new TextLogger());
            Console.WriteLine(calc.CalculateTax(10, 0));
        }
    }
}
