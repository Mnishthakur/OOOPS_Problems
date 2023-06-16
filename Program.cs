namespace Oops;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Harry";
        person1.Age = 25;

        Person person2 = new Person();
        person2.Name = "Rock";
        person2.Age = 36;

        person1.DisplayInfo();
        Console.WriteLine();
        person2.DisplayInfo();
        Console.ReadLine();


    }
}
