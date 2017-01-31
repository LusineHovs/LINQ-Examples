using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee {LastName = "A1yan", FirstName = "A1", Nationality = "Armeian"},
                new Employee { LastName = "A2yan", FirstName = "A5", Nationality = "Armeian"},
                new Employee {LastName = "A1yan", FirstName = "A3", Nationality = "Russiam"},
                new Employee {LastName = "A5yan", FirstName = "A1", Nationality = "American"}
            };

            var query = from emp in employees
                        group emp by new { emp.Nationality };

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                    Console.WriteLine(item.FirstName);
            }
        }
    }
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    }
}
