using System;

namespace a14
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoParameters result = new TwoParameters();
            Console.WriteLine("Enter an integer: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer (optional): ");
            string int2 = Console.ReadLine();
            if (string.IsNullOrEmpty(int2))
            {
                Console.WriteLine(result.Multiply(int1));
            }
            else
            {
                Console.WriteLine(result.Multiply(int1, Convert.ToInt32(int2)));
            }

            Console.ReadLine();
        }
    }
}
