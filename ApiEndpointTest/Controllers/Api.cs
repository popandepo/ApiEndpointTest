using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ApiEndpointTest.Controllers;

[Route("[controller]")]
[ApiController]
public class ApiController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		Log.Information($"Get request recieved");
		return Ok();
	}

	[HttpPost]
	public IActionResult Post()
	{
		Log.Information($"Post request recieved");
		return Ok();
	}
}