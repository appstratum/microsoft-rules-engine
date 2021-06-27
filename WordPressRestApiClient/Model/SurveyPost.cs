using System;
using System.Text.Json.Serialization;

 namespace WordPressRestApiClient
{
    public class SurveyPost 
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

        [JsonPropertyName("meta")] 
        public SurveyDefAttribute _SurveyDef { get; set; } 

        public string SurveyDef => _SurveyDef?.SurveyDef; 



        [JsonPropertyName("surveyID")]
        public string SurveyId { get; set; }

        [JsonPropertyName("surveyVersionNumber")]
        public string SurveyVersionNumber { get; set; }

        [JsonPropertyName("surveyGroup")]
        public string SurveyGroup { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }



        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("device")]
        public string Device { get; set; }



        [JsonPropertyName("resultsVisible")]
        public bool ResultsVisible { get; set; }

        [JsonPropertyName("surveyTheme")]
        public string SurveyTheme { get; set; }
        
        [JsonPropertyName("timeToComplete")]
        public int TimeToComplete { get; set; }


        // Taxonomy attributes

        [JsonPropertyName("categories")]
        public int [] Categories { get; set; }

        [JsonPropertyName("tags")]
        public int [] Tags { get; set; }


        [JsonPropertyName("e-consent-type")]
        public int [] EConsentType { get; set; }

        [JsonPropertyName("study")]
        public int [] Study { get; set; }

    }
}