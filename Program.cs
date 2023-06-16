namespace Oops;

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();

        Animal cat = new Cat();
        cat.MakeSound();
    }
}
