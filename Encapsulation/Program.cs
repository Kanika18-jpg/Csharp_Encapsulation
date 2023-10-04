using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
    

        public int id
        {
            get;  private set;
        }
        public Student(int iid)
        {
            id = iid;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student(1);
                s.id = 2;
                Console.WriteLine(s.id);
                Console.ReadLine();
            }
        }
    }
}
