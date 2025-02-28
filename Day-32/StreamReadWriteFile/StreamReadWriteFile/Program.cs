using StreamWriteFileApp.Models;


namespace StreamWriteFileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();

            string filePath = @"C:\Jayapreethi-html-app\sample.txt";

            FileWriter filewriter = new FileWriter(filePath);

            filewriter.WriteToFile(username, address);

            filewriter.Close();

            Console.WriteLine("Your data has been saved to C:\\minu-html-app\\StreamWriter\\foo.txt");
        }
    }
}