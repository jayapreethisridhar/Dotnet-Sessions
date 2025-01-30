using System;
using System.Text;
namespace Reverse
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0, j = numbers.Length - 1,temp;
            while (i != j)
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
                i++;
            }
            //int lastno = numbers.Length;
            //int Length = numbers.Length-1;
            //int next = numbers[i];
            //for (int i = 0; i < Length; i++)
            //{
            //    int temp = next;
            //    next = next+1;
            //    Length = temp;
                
                

            //}
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}