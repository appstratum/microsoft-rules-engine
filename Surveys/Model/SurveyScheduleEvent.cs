using System;

using SurveyRulesEngine.Common;


namespace Surveys.Model
{

    /// <summary>
    /// The responsibilility of the SurveyScheduleEvent is to hold data about
    /// the AvailbilityDate and ExpiryDate of a specific instance of a survey
    /// for a participant.
    /// </summary>
    public class SurveyScheduleEvent
    {

        /// <summary>
        /// The unique identifier for a SurveyScheduleEvent.
        /// </summary>
        public Guid ID { get; set; }


        /// <summary>
        /// A unique ID for a study Participant. This is a primary key value
        /// in the Participant table.
        /// </summary>
        public Guid ParticipantID { get; set; }


        /// <summary>
        /// A unique ID for a survey definition. This is a primary key value
        /// in the SurveyDefinition table.
        /// </summary>
        public Guid SurveyDefinitionID { get; set; }


        /// <summary>
        /// The time at which the survey will become available to a Participant.
        ///
        /// By default this is NEVER (DateTime.MaxValue) since DateTime is
        /// not a nullable type.
        /// </summary>
        public DateTime AvailableDate { get; set; }

        /// <summary>
        /// The time at which the survey will cease to be available to a
        /// a Participant.
        ///
        /// By default this is NEVER (DateTime.MaxValue) since DateTime is not
        /// a nullable type.
        /// </summary>
        public DateTime ExpiryDate { get; set; }



        /// <summary>
        /// The time at which this SurveyDefinition was created in the database.
        /// </summary>
        public DateTime CreatedAt { get; set; }


        /// <summary>
        /// The time at which this version of this SurveyDefinition record was
        /// created in the database.
        /// </summary>
        public DateTime ValidFrom { get; set; }


        /// <summary>
        /// The time at which this version of this SurveyDefinition record
        /// ceased to be valid. If this refers to a time in the future, then
        /// this version of the SurveyDefinition record is still valid.
        /// </summary>
        public DateTime ValidTo { get; set; }


        public SurveyScheduleEvent()
        {
            ID = Guid.NewGuid();

            AvailableDate = Constants.NEVER;
            ExpiryDate = Constants.NEVER;
        }

        public SurveyScheduleEvent(
            Guid id,
            Guid participantID,
            Guid surveyDefinitionID) 
        {
            ID = id;
            ParticipantID = participantID;
            SurveyDefinitionID = surveyDefinitionID;


            AvailableDate = Constants.NEVER;
            ExpiryDate = Constants.NEVER;

            var now = DateTime.UtcNow;

            CreatedAt = now;
            ValidFrom = now;
            ValidTo = DateTime.MaxValue;
        }

        public SurveyScheduleEvent(
            Guid id,
            Guid participantID,
            Guid surveyDefinitionID,

            DateTime availableDate,
            DateTime expiryDate,
            DateTime createdAt,
            DateTime validFrom,
            DateTime validTo) : this(id, participantID, surveyDefinitionID)
        {
            AvailableDate = availableDate;
            ExpiryDate = expiryDate;
            CreatedAt = createdAt;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
    }
}
