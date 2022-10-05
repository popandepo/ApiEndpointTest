using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ApiEndpointTest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VismaWebhooksController : ControllerBase
{
	[HttpPost]
	public async Task<ActionResult> Post(List<Notification> notifications)
	{
		Log.Information(string.Join(Environment.NewLine,notifications.Select(n=>$"Notification {n.NotificationId} recieved, object at {n.RelativeResourceUri} changed on {n.TimeStamp}")));
		return Ok();
	}
}