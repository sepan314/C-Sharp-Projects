using System;
namespace a18
{
    public class Employee : IQuittable
    {
        public string name;
        public void Quit()
        {
            Console.WriteLine($"{name} has quit");
        }
    }
}
