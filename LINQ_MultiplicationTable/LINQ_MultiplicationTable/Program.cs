using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from x in Enumerable.Range(1, 9)     // skzbum x=1 => y=1, 2,3,...  heto x=2 => y=1,2,3,...
                        from y in Enumerable.Range(1, 10)
                        select new                           // projection operation
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };
            foreach (var item in query)
                Console.WriteLine("{0}*{1}={2}", item.X, item.Y, item.Product);
        }
    }
}
