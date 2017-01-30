using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Firstname = "A1",
                    Lastname = "A1yan",
                    Salary = 90000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    Firstname = "A2",
                    Lastname = "A2yan",
                    Salary = 123000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                 new Employee
                {
                    Firstname = "A3",
                    Lastname = "A3yan",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
            };

            // this style is like in SQL 
            var query =
                from employee in employees
                where employee.Salary > 100000
                orderby employee.Lastname, employee.Firstname
                select new
                {
                    Lastname = employee.Lastname,
                    Firstname = employee.Firstname
                };
            Console.WriteLine("High paid employees");
            foreach (var item in query)
                Console.WriteLine($"{item.Lastname} {item.Firstname}");

            // var implemented IEnumerable

            //// Using Extension Methods
            //var query =
            //    employees
            //    .Where(emp => emp.Salary > 1000000)
            //    .OrderBy(emp => emp.Lastname)
            //    .OrderBy(emp => emp.Firstname)
            //    .Select(emp => new
            //    {
            //        Lastname = emp.Lastname,
            //        Firstname = emp.Firstname
            //    });

        }
    }
    internal class Employee
    {
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }
        public int Salary { get; internal set; }
        public DateTime StartDate { get; internal set; }
    }
}
