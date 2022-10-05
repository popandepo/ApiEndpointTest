using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace ApiEndpointTest;

public static class Helpers
{
	public static Logger LogBuilder(string url, string key, List<(string key, string value)> enrichers)
	{
		var levelSwitch = new LoggingLevelSwitch();
		var lc = new LoggerConfiguration()
			.MinimumLevel.Verbose()
			.Enrich.FromLogContext()
			.WriteTo.Console(LogEventLevel.Information)
			.WriteTo.Seq(url, apiKey: key, controlLevelSwitch: levelSwitch);
		foreach (var enricher in enrichers) lc.Enrich.WithProperty(enricher.key, enricher.value);
		return lc.CreateLogger();
	}
}