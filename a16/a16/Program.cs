using System;

namespace a16
{
    class Program
    {
        static void Main(string[] args)
        {
            App16 obj = new App16();
            Console.WriteLine("Enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            obj.Method1(input);
            obj.Method1();
            obj.Method2(out int x, out int y);
            Console.WriteLine("output parameters: {0}, {1}", x, y);
            Console.WriteLine("\n");
            StaticClass.SMethod();
            Console.ReadLine();
        }
    }

    static class StaticClass
    {
        public static void SMethod()
        {
            Console.WriteLine("This is my static class");
        }
    }
}
