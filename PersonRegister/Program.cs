using PersonRegister;

var register = new Register(new List<Person>());

var doLoop = true;
while (doLoop)
{
    PrintMenu();
    string? command;
    try
    {
        command = GetCommand();
    }
    catch (Exception)
    {
        Console.WriteLine("Bad Command, quit program");
        doLoop = false;
        continue;
    }
    switch (command.ToUpper())
    {
        case "A":
            string? name = GetName();
            double salary;
            try
            {
                salary = GetSalary();
            }
            catch
            {
                Console.WriteLine();
                continue;
            }
            var person = new Person(name, salary);
            register.AddPerson(person);
            Console.WriteLine($"Person <{person}> added");
            break;
        case "S":
            try
            {
                register.ShowwRegister();
            }
            catch (Exception)
            {
                continue;
            }
            break;
        default:
            doLoop = false;
            break;
    }
    Console.WriteLine();
}

static void PrintMenu()
{
    Console.WriteLine("Vad vill du görra?");
    Console.WriteLine("   A - Mata in en anställd?");
    Console.WriteLine("   S - Titta på registret?");
    Console.WriteLine("   Något annat - Avsluta?");
    Console.Write("> ");
}

static string? GetName()
{
    Console.WriteLine("Skriv in namn");
    var name = Console.ReadLine();
    return name;
}

static double GetSalary()
{
    Console.WriteLine("Skriv in lön");
    try
    {
        return double.Parse(Console.ReadLine().Replace(".", ","));
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input for salary!");
        throw;
    }
}

static string? GetCommand()
{
    return Console.ReadLine();
}