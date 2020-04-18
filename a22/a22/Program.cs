using System;
using System.IO;

namespace a22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            string filePath = @"/Users/sp/Desktop/C-Sharp-Projects/a22/a22/log.txt";


            File.WriteAllText(filePath, input);

            Console.WriteLine(File.ReadAllText(filePath));

            Console.ReadLine();
        }
    }
}
