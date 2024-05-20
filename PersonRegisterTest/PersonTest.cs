using PersonRegister;

namespace PersonRegisterTest
{
    public class PersonTest
    {
        [Fact]
        public void PersonCtorTest()
        {
            var person = new Person("Mikael", 12.4);

            Assert.Equal(person.ToString(), "Name: Mikael  Salary: 12,4");
        }
    }
}