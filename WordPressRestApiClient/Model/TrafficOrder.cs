using System;
using System.Text.Json.Serialization;

namespace WordPressRestApiClient
{
    public class TrafficOrder 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date_gmt")]
        public DateTime CreatedDate { get; set; }

        [JsonPropertyName("modified_gmt")]
        public DateTime ModifiedDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
        


        [JsonPropertyName("title")]
        public RenderedAttribute _Title { get; set; }
        public string Title => _Title?.Rendered;   


        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }


        [JsonPropertyName("startDateRule")]
        public string StartDateRule { get; set; }

        [JsonPropertyName("endDateRule")]
        public string EndDateRule { get; set; }


        // Taxonomy attributes

        [JsonPropertyName("categories")]
        public int [] Categories { get; set; }

        [JsonPropertyName("tags")]
        public int [] Tags { get; set; }

        [JsonPropertyName("study")]
        public int [] Study { get; set; }

    }
}