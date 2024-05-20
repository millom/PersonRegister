using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    public class Person
    {
        public Person(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}  Salary: {Salary}";
        }
    }
}
