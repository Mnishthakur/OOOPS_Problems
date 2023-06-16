namespace oops;
class Program
{
    class Person
    {
        public string Name { get; set; }
    }

    static void ModifyReference(Person person)
    {
        person.Name = "Alice";
        Console.WriteLine("Inside ModifyReference: " + person.Name);
    }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Bob";
        Console.WriteLine("Original name: " + person.Name);

        ModifyReference(person);

        Console.WriteLine("Name after calling ModifyReference: " + person.Name);
    }
}
