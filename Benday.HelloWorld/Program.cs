// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

namespace Benday.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IMessageProvider provider = new DateTimeInfoProvider();

            Console.WriteLine(provider.GetMessage());
        }
    }
}