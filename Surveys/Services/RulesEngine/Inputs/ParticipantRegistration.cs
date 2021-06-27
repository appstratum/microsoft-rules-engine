using System;

using SurveyRulesEngine.Common;


namespace Surveys.Services.RulesEngine.Input
{

    /// <summary>
    /// The responsibility of this class is to hold information about a
    /// Participant's registration.
    /// </summary>
    public class ParticipantRegistration
    {
        //private const int NOT_APPLICABLE = -1;
        //private static DateTime NOT_SET = new DateTime();

        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }

        public Survey Assent { get; set; }
        public Survey Consent { get; set; }
        public Survey Eligibility { get; set; }

        public ParticipantRegistration() : this(null, null, null)
        {
        }

        public ParticipantRegistration(Survey consent, Survey assent = null, Survey eligibility = null)
            {
            Assent = assent;
            Consent = consent;
            Eligibility = eligibility;

            if (eligibility != null)
            {
                StartedDate = eligibility.StartedDate;
            }
            else if (Assent != null)
            {
                StartedDate = assent.StartedDate;
            }
            else if (Consent != null)
            {
                StartedDate = consent.StartedDate;
            }

            if (Consent != null)
            {
                CompletedDate = consent.CompletedDate;
            }
            else
            {
                CompletedDate = DateTime.MaxValue;
            }

            eligibility = Survey.NullSurvey;
            assent = Survey.NullSurvey;
            consent = Survey.NullSurvey;
        }


        /// <summary>
        /// The number of days since the participant started the registration
        /// process.
        /// </summary>
        public int DaysSinceStarted
        {
            get
            {
                return Utils.DaysSince(StartedDate);
            }
        }

        /// <summary>
        /// The number of days sinc ethe participant ended the registration
        /// process.
        /// </summary>
        public int DaysSinceCompleted {
            get {
                return Utils.DaysSince(CompletedDate);
            }
        }

    }
}
