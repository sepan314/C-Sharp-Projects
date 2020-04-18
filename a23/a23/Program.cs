using System;

namespace a23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine("Enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(now.AddHours(hours));



            Console.ReadLine();
        }
    }
}
