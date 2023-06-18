using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public virtual void SayHello()
        {
            Console.WriteLine("Say Hello from Person");
        }
        public Person(string firstName1,
            string lastName1,
            string city1,
            int age1)
        {
            FirstName = firstName1;
            LastName = lastName1;
            City = city1;
            Age = age1;
        }

    }
}
