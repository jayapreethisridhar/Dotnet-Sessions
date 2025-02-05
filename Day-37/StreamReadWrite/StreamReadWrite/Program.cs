using System;
using System.IO;
using System.Runtime.InteropServices;
namespace StreamReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenerateHtmlFile();
            ReadTheHtmlFile();

        }
        private static void ReadTheHtmlFile()
        {
            var fs = new FileStream("C:\\temp\\welcome.html", FileMode.Open);
            var sr = new StreamReader(fs);
             var html = sr.ReadToEnd();
             Console.WriteLine(html);


            while (true)
            {
                var line = sr.ReadLine();
                if (line == null) break;
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
        private static void GenerateHtmlFile()
        {


            var myhtmlbody = $"html" + $"body" + 
                $"<h1>Welcome to the html page</h1>" +
                $"</body>" +
                $"</ html >";

                FileStream fs = new FileStream("C:\\temp\\Welcome.html", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(myhtmlbody);
            sw.Close();
            fs.Close();

            System.Console.WriteLine("End of program");
        }
    }
}