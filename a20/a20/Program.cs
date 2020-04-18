using System;

namespace a20
{
    class Program
    {

        enum Week
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string input = Console.ReadLine();
            try
            {
                Week myEnum = (Week)Enum.Parse(typeof(Week), input);
                Console.WriteLine((int)myEnum);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();
        }
    }
}
