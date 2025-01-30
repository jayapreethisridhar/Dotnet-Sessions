using System;
using System.Text;
namespace Reverse
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] str = { "Preethi", "Shalini", "Venkat", "Jaya" };

            int LengthofArray = str.Length - 1;

            for (int i = 0; i < LengthofArray; i++)
            {
                String temp = str[i];
                str[i] = str[LengthofArray];
                str[LengthofArray] = temp;
                LengthofArray--;

            }
            foreach (string array in str)
            {
                Console.WriteLine(array);
            }
        }
    }
}