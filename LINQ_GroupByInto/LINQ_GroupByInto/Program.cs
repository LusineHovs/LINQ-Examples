using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupByInto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = from x in numbers
                        group x by x % 2 into partition
                        where partition.Key == 0
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Count);

                foreach (var number in item.Group)
                    Console.Write("{0}, ", number);


                Console.ReadKey();
            }
        }
    }
}
