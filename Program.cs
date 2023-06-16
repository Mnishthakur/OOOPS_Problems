class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

// Single inheritance
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

// Multilevel inheritance
class GoldenRetriever : Dog
{
    public void Fetch()
    {
        Console.WriteLine("The Golden Retriever is fetching.");
    }
}

// Hierarchical inheritance
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing.");
    }
}

// Multiple inheritance using interfaces
interface ICanSwim
{
    void Swim();
}

interface ICanFly
{
    void Fly();
}

class Duck : ICanSwim, ICanFly
{
    public void Swim()
    {
        Console.WriteLine("The duck is swimming.");
    }

    public void Fly()
    {
        Console.WriteLine("The duck is flying.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single inheritance
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine();

        // Multilevel inheritance
        GoldenRetriever goldenRetriever = new GoldenRetriever();
        goldenRetriever.Eat();
        goldenRetriever.Bark();
        goldenRetriever.Fetch();

        Console.WriteLine();

        // Hierarchical inheritance
        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();

        Console.WriteLine();

        // Multiple inheritance using interfaces
        Duck duck = new Duck();
        duck.Swim();
        duck.Fly();
    }
}
