using System;

using SurveyRulesEngine.Common;

namespace Surveys.Services.RulesEngine.Input
{

    /// <summary>
    /// The responsibility of this class is to hold information about the
    /// a survey. A survey can be a historic survey or a current survey for
    /// which survey rules are being evaluated.
    /// </summary>
    public class Survey
    {

       
        public static readonly Survey NullSurvey = new Survey("", "", "NullSurvey", "", Constants.NEVER, Constants.NEVER, "");


        public string Id { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string SurveyGroup { get; set; }

        public DateTime AvailableDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }

        public Survey()
        {
        }

        public Survey(string id, string version, string type, string subtype,
            string surveyGroup = null)
        {
            Id = id;
            Version = version;
            Type = type;
            Subtype = subtype;
            SurveyGroup = surveyGroup;

            StartedDate = Constants.NEVER;
            CompletedDate = Constants.NEVER;

        }

        public Survey(string id, string version, string type, string subtype,
            DateTime startedDate, DateTime completedDate,
            string surveyGroup = null): this(id, version, type, subtype, surveyGroup)
        {
            StartedDate = startedDate;
            CompletedDate = completedDate;
        }


        /// <summary>
        /// The number of days since this survey was available to the
        /// Participant. Or NOT_APPLICABLE if the AvailableDate wasn't set.
        /// </summary>
        public int DaysSinceAvailable
        {
            get
            {
                return Utils.DaysSince(AvailableDate);
            }
        }

        /// <summary>
        /// The number of days since this survey was expired for the
        /// Participant. Or NOT_APPLICABLE if the expiry date was not set.
        /// </summary>
        public int DaysSinceExpiry
        {
            get
            {
                return Utils.DaysSince(ExpiryDate);
            }
        }


        /// <summary>
        /// The number of days since this survey was started. Or NOT_APPLICABLE
        /// if it wasn't started.
        /// </summary>
        public int DaysSinceStarted
        {
            get
            {
                return Utils.DaysSince(StartedDate);
            }
        }

        /// <summary>
        /// The number of days since this survey was completed. Or NOT_APPLICABLE
        /// if it wasn't completed.
        /// </summary>
        public int DaysSinceCompleted
        {
            get
            {
                return Utils.DaysSince(CompletedDate);
            }
        }


        /// <summary>
        /// The number of days until this survey is available to the
        /// Participant. Or MAX_DAYS if the AvailableDate wasn't set.
        /// </summary>
        public int DaysUntilAvailable
        {
            get
            {
                return Utils.DaysUntil(AvailableDate);
            }
        }

        /// <summary>
        /// The number of days since this survey was expired for the
        /// Participant. Or MAX_DAYS if the expiry date was not set.
        /// </summary>
        public int DaysUntilExpiry
        {
            get
            {
                return Utils.DaysUntil(ExpiryDate);
            }
        }


    }
}
