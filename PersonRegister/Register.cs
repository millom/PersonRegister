using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    internal class Register
    {
        List<Person> list;

        public Register(List<Person> list)
        {
            this.list = list;
        }

        public void AddPerson()
        {
            Console.WriteLine("Skriv in namn");
            var name = Console.ReadLine();
            Console.WriteLine("Skriv in lön");
            var salary = double.Parse(Console.ReadLine());
            list.Add(new Person(name, salary));
        }

        public void ShowwRegister()
        {
            Console.WriteLine("Register printout");
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
