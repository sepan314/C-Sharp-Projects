using System;

namespace a3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is: " + (num1 * 50));

            Console.Write("Please enter an integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is: " + (num2 + 25));

            Console.Write("Please enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The output is: " + (num3 / 12.5));

            Console.Write("Please enter an integer: ");
            bool num4 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("The output is: " + num4);

            Console.Write("Please enter an integer: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is: " + (num5 % 7));

            Console.ReadLine();

        }
    }
}
