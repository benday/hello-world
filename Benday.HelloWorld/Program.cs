// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

namespace Benday.HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, World!");

        IMessageProvider provider = new DateTimeInfoProvider();

        WriteLine(provider.GetMessage());
    }

    public static void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}