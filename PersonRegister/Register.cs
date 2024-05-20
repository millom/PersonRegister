using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    public class Register
    {
        public Register(List<Person> list)
        {
            this.List = list;
        }

        public List<Person> List { get; set; }

        public void AddPerson(Person person)
        {
            List.Add(person);
        }

        public void ShowwRegister()
        {
            Console.WriteLine("Register printout");
            foreach (Person person in List)
            {
                Console.WriteLine(person);
            }
        }
    }
}
