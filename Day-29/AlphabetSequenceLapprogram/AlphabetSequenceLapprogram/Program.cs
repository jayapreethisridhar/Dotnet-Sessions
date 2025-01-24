using System;
namespace AlphabetSequenceLapprogram
{
    public class Program
    {
        static bool isAlphabetOrder(String s)
        {
            int n = s.Length;
            char[] c = new char[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = s[i];

            }
            Array.Sort(c);
            for (int i = 0; i < n; i++)
            {
                if (c[i] != s[i])
                    return false;

            }
            return true;
        }
        public static void Main()
        {
            String s = "abcdef";
            if (isAlphabetOrder(s))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("NO");

        }
    }
}