using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Student : Person
    {
        public int Level { get; set; }
        public override void SayHello()
        {
           
            Console.WriteLine("Say Hello from Student");
          
        }
        public Student(
            string firstName,
            string lastName,
            string city,
            int age,
            int level): base(firstName,lastName, city, age)
        {
           
            Level = level;
        }
    }
}
