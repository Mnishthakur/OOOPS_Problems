using System;
namespace oops;

class Program
{
    static void Main(string[] args)
    {
        // Integer types
        byte byteVar = 255;
        sbyte sbyteVar = -128;
        short shortVar = -32768;
        ushort ushortVar = 65535;
        int intVar = -2147483648;
        uint uintVar = 4294967295;
        long longVar = -9223372036854775808;
        ulong ulongVar = 18446744073709551615;

        // Floating-point types
        float floatVar = 3.14f;
        double doubleVar = 3.14159;
        decimal decimalVar = 3.1415926535897932384626433832m;

        // Character type
        char charVar = 'A';

        // Boolean type
        bool boolVar = true;

        // String type
        string stringVar = "Hello, World!";

        Console.WriteLine("Integer Types:");
        Console.WriteLine("byte: " + byteVar);
        Console.WriteLine("sbyte: " + sbyteVar);
        Console.WriteLine("short: " + shortVar);
        Console.WriteLine("ushort: " + ushortVar);
        Console.WriteLine("int: " + intVar);
        Console.WriteLine("uint: " + uintVar);
        Console.WriteLine("long: " + longVar);
        Console.WriteLine("ulong: " + ulongVar);

        Console.WriteLine("\nFloating-Point Types:");
        Console.WriteLine("float: " + floatVar);
        Console.WriteLine("double: " + doubleVar);
        Console.WriteLine("decimal: " + decimalVar);

        Console.WriteLine("\nCharacter Type:");
        Console.WriteLine("char: " + charVar);

        Console.WriteLine("\nBoolean Type:");
        Console.WriteLine("bool: " + boolVar);

        Console.WriteLine("\nString Type:");
        Console.WriteLine("string: " + stringVar);
    }
}
