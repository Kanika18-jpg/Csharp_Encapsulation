using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Encapsulation

{
    internal class Employee
    {
        private readonly int id;
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }

        } 
        public int Id
        {
            get { return 1; }
        }
        public double Salary
        {
            get { return salary; }

            set {
                if (value > 0) {  salary = value; }
                 }
        }
        
    }
    class Program4
    {
        public static void Main(String[] args)
        {
            Employee e1 = new Employee();
            e1.Salary = 50000;
            e1.Name = "Kanika";

            Console.WriteLine("The name is " + e1.Name);
            
            Console.WriteLine("The salary is " + e1.Salary);

            Console.ReadLine();
            
        }
    }
}
