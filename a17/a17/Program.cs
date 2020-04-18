using System;
using System.Collections.Generic;
using System.Linq;

namespace a17
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ FirstName = "Bob", LastName = "Bobson", Id = 1},
                new Employee(){ FirstName = "John", LastName = "Johnson", Id = 2},
                new Employee(){ FirstName = "Mike", LastName = "Mikeson", Id = 3},
                new Employee(){ FirstName = "Joe", LastName = "Joeson", Id = 4},
                new Employee(){ FirstName = "Billy", LastName = "Billyson", Id = 5},
                new Employee(){ FirstName = "Tim", LastName = "Timson", Id = 6},
                new Employee(){ FirstName = "Larry", LastName = "Larryson", Id = 7},
                new Employee(){ FirstName = "Joe", LastName = "Lobson", Id = 8},
                new Employee(){ FirstName = "Tom", LastName = "Tomson", Id = 9},
                new Employee(){ FirstName = "Zach", LastName = "Zachson", Id = 10},

            };

            List<Employee> new_emp = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    new_emp.Add(emp);

                }
            }

            List<Employee> lambda_list = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> lambda_list2 = employees.Where(x => x.Id > 5).ToList();

            Console.ReadLine();

        }


    }
}
