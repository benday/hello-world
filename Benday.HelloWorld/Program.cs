// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

namespace Benday.HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // this is a comment
        WriteLine("Hello, World!");

        WriteLine(string.Empty);

        IMessageProvider provider = new DateTimeInfoProvider();
        ILuckyNumberProvider numberProvider = new DateTimeInfoProvider();

        int luckyNumber = numberProvider.GetLuckyNumber();

        WriteLine($"{provider.GetMessage()} -- btw, the lucky number is {luckyNumber}");

    }

    public static void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}