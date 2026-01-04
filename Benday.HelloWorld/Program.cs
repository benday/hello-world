// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

Console.WriteLine("Hello, World!");

IMessageProvider provider = new DateTimeInfoProvider();

Console.WriteLine(provider.GetMessage());