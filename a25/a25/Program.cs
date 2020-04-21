using System;

namespace a25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                int DOByear = 2020 - age;
                Console.WriteLine("The year you were born in: " + DOByear);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            catch (Exception)
            {
                Console.WriteLine("Input error: integers only");
            }


            Console.ReadLine();
        }
    }
}
