using System;
namespace a17
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a.Id == b.Id);
        }

    }
}
