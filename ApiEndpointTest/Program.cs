using ApiEndpointTest;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();
Log.Logger = Helpers.LogBuilder(builder.Configuration["SeqPath"], builder.Configuration["SeqApiKey"],
	new List<(string key, string value)>
	{
		("Application", "ApiEndpointTest"),
		("Mode", builder.Configuration["ASPNETCORE_ENVIRONMENT"])
	});

Log.Information("Creating Seq connection");
Log.Information("Building server");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();