using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int page_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool need_help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string pos_exp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}