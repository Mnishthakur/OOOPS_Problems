namespace oops;
class Program
{
    static void ModifyValue(int x)
    {
        x = 10;
        Console.WriteLine("Inside ModifyValue: " + x);
    }

    static void Main(string[] args)
    {
        int num = 5;
        Console.WriteLine("Original value: " + num);

        ModifyValue(num);

        Console.WriteLine("Value after calling ModifyValue: " + num);
    }
}
