using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_withNonGenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            var query = from int n in numbers
                        select new { Digit = n * 2 };
            foreach (var item in query)
            {
                Console.WriteLine(item.Digit);
            }
        }
    }
}
