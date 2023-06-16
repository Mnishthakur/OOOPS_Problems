namespace oops;
class Program
{
    // Static method
    static void DisplayMessage()
    {
        Console.WriteLine("This is a static method.");
    }

    // Method with parameters
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Method with return type
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method with output parameter
    static void GetMax(int a, int b, out int max)
    {
        max = (a > b) ? a : b;
    }

    // Method with optional parameters
    static void GreetUser(string name, string greeting = "Hello")
    {
        Console.WriteLine(greeting + ", " + name + "!");
    }

    static void Main(string[] args)
    {
        // Calling a static method
        DisplayMessage();

        // Calling a method with parameters
        int sum = AddNumbers(5, 3);
        Console.WriteLine("Sum: " + sum);

        // Calling a method with return type
        int number = 10;
        bool isEven = IsEven(number);
        Console.WriteLine(number + " is even: " + isEven);

        // Calling a method with an output parameter
        int x = 10;
        int y = 20;
        int max;
        GetMax(x, y, out max);
        Console.WriteLine("Max: " + max);

        // Calling a method with optional parameters
        string userName = "John";
        GreetUser(userName);
        GreetUser(userName, "Welcome");
    }
}
