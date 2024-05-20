using PersonRegister;

namespace PersonRegisterTest
{
    public class RegisterTest
    {
        [Fact]
        public void RegisterCtorTest()
        {
            List<Person> list = new();

            var register = new Register(list);
            Assert.Same(register.List, list);
        }

        [Fact]
        public void RegisterAddPersonTest()
        {
            var addedPerson = new Person("Mikael", 11.1);

            var register = new Register(new List<Person>());
            register.AddPerson(addedPerson);

            Assert.Same(addedPerson, register.List[0]);
        }
    }
}