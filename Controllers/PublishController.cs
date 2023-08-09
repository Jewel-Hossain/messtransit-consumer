//In the name of Allah

using MassTransit;
using MassTransit.My.Publisher;
using Messtransit.My.Contracts;
using Messtransit.My.Utils;
using Microsoft.AspNetCore.Mvc;

namespace messtransit_pubsub.Controllers;

[ApiController]
[Route("[controller]")]
public class PublishController : ControllerBase
{
    private readonly MyPublisher _publisher;

    public PublishController(MyPublisher publisher)
    {
        _publisher = publisher;
    }


    [HttpPost("PublishCity")]
    public async Task<IActionResult> PublishCity([FromBody] CityContract message)
    {
        _publisher.MessagePublisher(QueueNames.RESTAURANT_SERVICE_QUEUE,message);

        return Ok(message);
    }//func

}//class
