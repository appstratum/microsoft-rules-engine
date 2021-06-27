using System.Text.Json.Serialization;

namespace WordPressRestApiClient 
{
    public class RenderedAttribute 
    {
        [JsonPropertyName("rendered")]
        public string Rendered { get; set; }
    }
}