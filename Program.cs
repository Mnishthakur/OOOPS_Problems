namespace oops
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Brand = "Toyota";
        car.Model = "Camry";
        car.Year = 2021;

        Console.WriteLine("Car Information:");
        Console.WriteLine("Brand: " + car.Brand);
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Year: " + car.Year);

        car.StartEngine();
        car.StopEngine();
    }
}
