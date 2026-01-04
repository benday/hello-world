// See https://aka.ms/new-console-template for more information
using Benday.HelloWorld.Api;

Console.WriteLine("Hello, World!");

IMessageProvider provider = new DateTimeInfoProvider();
ILuckyNumberProvider numberProvider = new DateTimeInfoProvider();

string message = provider.GetMessage();

int luckyNumber = numberProvider.GetLuckyNumber();

Console.WriteLine($"{message} -- btw, the lucky number is {luckyNumber}");

