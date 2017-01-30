using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class MyClass
    {
        public int field;
        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    delegate void MyDelegate(string str);


    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Types
            var instance = new { Name = "Maria", Age = 4 };
            Console.WriteLine($"Name = {instance.Name}, Age = {instance.Age}");
            Type type = instance.GetType();
            Console.WriteLine(type.ToString());
            Console.ReadKey();



            //Anonymous Types (strong reference)
            var instance1 = new { my = new MyClass()};
            instance1.my.field = 1;
            instance1.my.Method();


            //Anonymous Types (using delegates)
            var instance2 = new {myDel = new MyDelegate((string str) => Console.WriteLine(str))};
            instance2.myDel.Invoke("Hello");
            Console.ReadKey();
        }
    }
}
