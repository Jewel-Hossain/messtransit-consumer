using MassTransit;
using Messtransit.My.Contracts;

namespace MassTransit.My.Consumers;
public class MyMessageConsumer : IConsumer<MyMessageContract>
{
    public async Task Consume(ConsumeContext<MyMessageContract> context)
    {
        var data = context.Message;
        //Validate the Ticket Data
        //Store to Database
        //Notify the user via Email / SMS
        Console.WriteLine($"Recived message {data.Text}");
    }//func
}//class