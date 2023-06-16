namespace Oops;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 5);
        dog.PrintInfo();
        dog.MakeSound();

        Console.WriteLine();

        Cat cat = new Cat("Whiskers", 3);
        cat.PrintInfo();
        cat.MakeSound();
    }
}
