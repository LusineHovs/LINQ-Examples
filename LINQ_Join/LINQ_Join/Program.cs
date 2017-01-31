using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<EmployeeID>
            {
                new EmployeeID {ID = "111", Name = "A1 A1yan"},
                new EmployeeID {ID = "222", Name = "A2 A2yan"},
                new EmployeeID {ID = "333", Name = "A3 A3yan"},
                new EmployeeID {ID = "444", Name = "A4 A4yan"}
            };

            var empNation = new List<EmployeeNationality>
            {
                new EmployeeNationality {ID = "111", Nationality = "ARM"},
                new EmployeeNationality {ID = "222", Nationality = "US"},
                new EmployeeNationality {ID = "333", Nationality = "RU"}
            };

            var query = from emp in employees
                        join nation in empNation
                        on emp.ID equals nation.ID
                        orderby nation.Nationality descending
                        select new
                        {
                            Id = emp.ID,
                            name = emp.Name,
                            nationality = nation.Nationality
                        };

            foreach (var item in query)
                Console.WriteLine("{0} {1} {2}", item.Id, item.name, item.nationality);
        }
    }

    public class EmployeeNationality
    {
        public string ID { get; internal set; }
        public string Nationality { get; internal set; }
    }

    public class EmployeeID
    {
        public string ID { get; internal set; }
        public string Name { get; internal set; }
    }
}
