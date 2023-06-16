namespace Oops;
class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle();
        shapes[1] = new Square();
        shapes[2] = new Triangle();

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
