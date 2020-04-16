using System;
namespace a17
{
    public class Person
    {
        public string FirstName;
        public string LastName;


        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
