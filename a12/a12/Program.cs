using System;

namespace a12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add1000: " + IntegerMethods.Add1000(input));
            Console.WriteLine("Multiply3: " + IntegerMethods.Multiply3(input));
            Console.WriteLine("Square: " + IntegerMethods.Square(input));



            Console.ReadLine();
        }
    }
}
