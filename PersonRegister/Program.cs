using PersonRegister;

var register = new Register(new List<Person>());

var doLoop = true;
while (doLoop)
{
    Console.WriteLine("Vad vill du görra?");
    Console.WriteLine("   A - Mata in en anställd?");
    Console.WriteLine("   S - Titta på registret?");
    Console.WriteLine("   Något annat - Avsluta?");
    Console.Write("> ");
    var command = Console.ReadLine();
    switch(command.ToUpper())
    {
        case "A":
            Console.WriteLine("Skriv in namn");
            var name = Console.ReadLine();
            Console.WriteLine("Skriv in lön");
            var salary = double.Parse(Console.ReadLine().Replace(".", ","));
            register.AddPerson(new Person(name, salary));
            break;
        case "S":
            register.ShowwRegister();
            break;
        default:
            doLoop = false;
            break;
    }
    Console.WriteLine();
}