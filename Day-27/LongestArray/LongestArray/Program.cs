using System;
namespace LongestArray
{
    public class Programs
    {
        public static void Main()
        {
            int maxcount = 3;
            string[] inputArray = { "abc", "efgh", "ijkl", "lmn" };
            string maxx = inputArray[inputArray.Length - 1];
            //string[] resultArray = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                //string Length = inputArray[i];
                
                if (inputArray[i].Length > maxcount)
                {
                    maxx = inputArray[i];
                    maxcount = inputArray[i].Length;
                }
             Console.WriteLine(inputArray[i]);
             //Console.WriteLine(resultArray[i]);
                Console.WriteLine("Longest" + maxcount);
            }
        }
        
        
    }
}
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace OutputArrayLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Longest Name in the Array\n");
            string[] names = { "Jaya", "Shalini", "Venkat", "Markonda", "Vignesh" };
            Console.WriteLine("The Names are");
            Console.WriteLine("================");
            foreach (string name in names)
            { Console.WriteLine(name); }
            string[] OutputArray = LongestName(names);
            Console.WriteLine("\nThe Longest Names are:");
            Console.WriteLine("=======================");
            foreach (string name in OutputArray)
            {
                Console.WriteLine(name);
            }

        }

        public static string[] LongestName(string[] namesArray)
        {


            int HighestnameLength = 0;
            int count = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i].Length > HighestnameLength)
                {
                    HighestnameLength = namesArray[i].Length;
                }
            }
            count = Counter(namesArray, HighestnameLength);
            string[] resultArray = new string[count];
            int index = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {

                if (namesArray[i].Length == HighestnameLength)
                {
                    resultArray[index] = namesArray[i];
                    index++;

                }
            }
            return resultArray;
        }
        public static int Counter(string[] names, int length)
        {
            int counterNo = 0;
            foreach (string name in names)
            {
                if (name.Length == length)
                {
                    counterNo = counterNo + 1;

                }
            }
            return counterNo;
        }
    }
}



