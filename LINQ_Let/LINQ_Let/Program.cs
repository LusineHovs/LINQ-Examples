using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Let
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee {Lastname = "A1yan", Firstname = "A1"},
                new Employee {Lastname = "A2yan", Firstname = "A2"}
            };

            var query = from emp in employees
                        let fullname = emp.Firstname + " " + emp.Lastname
                        orderby fullname descending
                        select fullname;

            foreach (var item in query)
                Console.WriteLine(item);
        }
    }
    public class Employee
    {
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }
    }
}
