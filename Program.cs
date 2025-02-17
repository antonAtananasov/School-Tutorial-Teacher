// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int n = 1;
        Print(n);
    }

    static void Print(int n)
    {
        Console.WriteLine($"{n++} {Console.ReadLine()}");
    }
}