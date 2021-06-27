using System;
namespace Surveys.Model
{

    /// <summary>
    /// <para>
    ///     The responsibibility of this class is to hold metadata about a
    ///     survey definition as well as the model for the survey definition
    ///     itself.
    /// </para>
    /// </summary>
    public class SurveyDefinition
    {

        /// <summary>
        /// The unique identifier for this version of this SurveyDefinition
        /// within the database.
        /// </summary>
        public Guid ID { get; set; }


        /// <summary>
        /// The title of this SurveyDefinition.
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// The URL of this SurveyDefinition in the source content management
        /// system (if applicable).
        /// </summary>
        public string URL { get; set; }


        /// <summary>
        /// The primary type of this survey. This determines how and when the
        /// survey responses will be stored.
        /// </summary>
        public string SurveyType { get; set; }


        /// <summary>
        /// The secondary type of this survey. This determines how and when the
        /// survey will be displayed.
        /// </summary>
        public string SurveySubType { get; set; }


        /// <summary>
        /// The unique identifier for this survey within the source content
        /// management system (if applicable).
        /// </summary>
        public string SurveyDefinitionCmsId { get; set; }


        /// <summary>
        /// The unique version of this survey for the SurveyDefinitionCmsId
        /// within the source content management system (if applicable).
        /// </summary>
        public string SurveyDefinitionCmsVersion { get; set; }


        /// <summary>
        /// The logical grouping of this survey, as defined by the content
        /// management system (if applicable).
        /// </summary>
        public string SurveyGroup { get; set; }


        /// <summary>
        /// The two letter country code for the country for which this version
        /// of this survey is targeted.
        /// </summary>
        public string Country { get; set; }


        /// <summary>
        /// The locale for the region for which this version of this survey
        /// is targeted. 
        /// </summary>
        public string Language { get; set; }


        /// <summary>
        /// The device(s) targetted by this version of the survey.
        /// </summary>
        public string Device { get; set; }


        /// <summary>
        /// Determines whether or not results should be displayed.
        /// </summary>
        public bool ResultsVisible { get; set; }


        /// <summary>
        /// The styling theme that should be applied to this survey when
        /// rendered in the UI.
        /// </summary>
        public string SurveyTheme { get; set; }


        /// <summary>
        /// The estimated time (in minutes) to complete this survey.
        /// </summary>
        public Int16 TimeToComplete { get; set; }


        /// <summary>
        /// The survey definition JSON source code.
        /// </summary>
        public string Model { get; set; }


        /// <summary>
        /// The time (in UTC) at which the survey definition model was created,
        /// as reported by the content management system.
        /// </summary>
        public DateTime ModelCreatedAt { get; set; }


        /// <summary>
        /// The time (in UTC) at which the survey definition model was last
        /// updated, as reported by the content management system.
        /// </summary>
        public DateTime ModelUpdatedAt { get; set; }


        /// <summary>
        /// The time (in UTC) at which this record was created in the database.
        /// </summary>
        public DateTime CreatedAt { get; set; }


       
        public SurveyDefinition()
        {
            ID = Guid.NewGuid();

            var now = DateTime.Now;

            ModelCreatedAt = now;
            ModelUpdatedAt = now;
            CreatedAt = now;
        }


        public SurveyDefinition(
            Guid id,
            string title,
            string url,
            string surveyType,
            string surveySubType,

            string surveyDefinitionCmsId,
            string surveyDefinitionCmsVersion,
            string surveyGroup,
            string country,
            string language,

            string device,
            bool resultsVisible,
            string surveyTheme,
            Int16 timeToComplete,

            string model,
            DateTime modelCreatedAt,
            DateTime modelUpdatedAt,
            DateTime createdAt)
        {
            ID = id;
            Title = title;
            URL = url;
            SurveyType = surveyType;
            SurveySubType = surveySubType;

            SurveyDefinitionCmsId = surveyDefinitionCmsId;
            SurveyDefinitionCmsVersion = surveyDefinitionCmsVersion;
            SurveyGroup = surveyGroup;
            Country = country;
            Language = language;

            Device = device;
            ResultsVisible = resultsVisible;
            SurveyTheme = surveyTheme;
            TimeToComplete = timeToComplete;

            Model = model;
            ModelCreatedAt = modelCreatedAt;
            ModelUpdatedAt = modelUpdatedAt;
            CreatedAt = createdAt;
        }



    }
}
