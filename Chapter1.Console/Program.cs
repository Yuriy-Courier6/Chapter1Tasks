using Chapter1.HelloMessageFormatter;

Console.WriteLine("Hello, World!");
string input = default!;

do
{
    Console.Write("Enter your name: ");
    input = Console.ReadLine()!;
    if (!string.IsNullOrWhiteSpace(input))
    {
        break;
    }

    Console.WriteLine("The name is empty! Press any key to try again.");
    Console.ReadKey();

} while (true);

Console.WriteLine(Formatter.FormatHelloMessage(input));
Console.ReadKey();