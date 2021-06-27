using System.Text.Json.Serialization;

namespace WordPressRestApiClient

{
    public class SurveyDefAttribute 
    {
        [JsonPropertyName("surveyDef")]
        public string SurveyDef { get; set; }
    }
}