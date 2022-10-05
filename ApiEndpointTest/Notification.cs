using System.Text.Json.Serialization;

namespace ApiEndpointTest
{
    public class Notification
    {
	    //[JsonPropertyName("notificationId")]
	    public string NotificationId { get; set; }

	    //[JsonPropertyName("contextId")]
	    public string ContextId { get; set; }

	    //[JsonPropertyName("event")]
	    public string Event { get; set; }

	    //[JsonPropertyName("relativeResourceUri")]
	    public string RelativeResourceUri { get; set; }

	    //[JsonPropertyName("resourceUri")]
	    public string ResourceUri { get; set; }

	    //[JsonPropertyName("action")]
	    public string Action { get; set; }

	    //[JsonPropertyName("timeStamp")]
	    [JsonConverter(typeof(JsonTimestampConverter))]
	    public DateTime TimeStamp { get; set; }
    }
}
