// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

namespace Benday.HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, World!");

        var provider = new DateTimeInfoProvider();
        var numberProvider = new DateTimeInfoProvider();

        var luckyNumber = numberProvider.GetLuckyNumber();

        WriteLine($"{provider.GetMessage()} -- btw, the lucky number is {luckyNumber}");
    }

    public static void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}
