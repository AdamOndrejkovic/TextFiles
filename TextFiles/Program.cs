using System;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\adamo\RiderProjects\TextFiles\TextFiles\Text.txt");

            Console.WriteLine($"Text file contains following text: {text}");

            string[] linesToAdd = { "Some random", "text that", "will be add", "to text file" };
            
            File.WriteAllLines(@"C:\Users\adamo\RiderProjects\TextFiles\TextFiles\Text.txt",linesToAdd);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\adamo\RiderProjects\TextFiles\TextFiles\Text.txt");

            foreach (var line in lines)
            {
                Console.WriteLine($"{line}");
            }

            Console.ReadKey();
        }
    }
}