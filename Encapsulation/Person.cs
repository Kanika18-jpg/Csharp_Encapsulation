using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                if(value>0)
                {
                age = value;}
            }
            get { return age; }
        }
    }
    class Program2
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Kanika";
            person.Age = 10;

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");

            Console.ReadLine();
        }
    }
}
