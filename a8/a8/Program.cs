using System;
using System.Text;

namespace a8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I " + "want " + "ice cream!");
            Console.WriteLine("upper".ToUpper());

            StringBuilder s = new StringBuilder();

            s.Append("Twinkle, twinkle, little star, \n");
            s.Append("How I wonder what you are!\n");
            s.Append("Up above the world so high,\n");
            s.Append("Like a diamond in the sky.\n");
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}

