using System;
namespace a24
{
    public class Person
    {
        public const string species = "Homo sapiens";

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() : this("John", "Doe")
        {
        }

        public Person(string FName, string LName)
        {
            FirstName = FName;
            LastName = LName;
        }

    }
}
