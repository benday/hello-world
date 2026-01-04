namespace Benday.HelloWorld.Api;

public class DateTimeInfoProvider : IMessageProvider, ILuckyNumberProvider
{
    public string GetMessage()
    {
        return $"The current date and time is: {DateTime.Now}";
    }

    public int GetLuckyNumber()
    {
        var rnd = new Random();

        var luckyNumber = rnd.Next();

        return luckyNumber;
    }
}
