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

        public void AddPerson(Person person)
        {
            list.Add(person);
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
