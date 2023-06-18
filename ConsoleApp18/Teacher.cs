using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Teacher:Person
    {
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {City}";
        }
        public override void SayHello()
        {
            Console.WriteLine("Say Hello from Teacher");
        }
        public Teacher(
            string firstName,
            string lastName,
            string city,
            int age,
            string subject):base(firstName, lastName, city, age)
        {
           
            Subject = subject;
        }
    }
}
