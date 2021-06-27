using System;
using System.Collections.Generic;

using SurveyRulesEngine.Common;


namespace Surveys.Services.RulesEngine.Input
{

    /// <summary>
    /// <para>
    ///     The responsibility of this class is to provide access to information
    ///     about the survey completion history for this participant.
    /// </para>
    /// <para>
    ///     
    /// </para>
    /// </summary>
    public class SurveyHistory
    {


        /// <summary>
        /// This should be a data access object to read the participants
        /// survey completion history directoy from the database or simply a
        /// list of surveys (with availability dates, expiry dates,
        /// started dates and completion dates for each survey).
        /// </summary>
        private readonly List<Survey> _surveyList;



        public SurveyHistory(List<Survey> surveyList)
        {
            _surveyList = surveyList;
        }


        /// <summary>
        /// Finds the number of days since a historic survey became available.
        /// </summary>
        /// <param name="surveyId">The identifier for the survey</param>
        /// <returns>The number pf days since the survey became available or
        /// NOT_APPLICABLE if the AvailableDate is not set.</returns>
        public int DaysSinceAvailable(string surveyId)
        {
            var survey = _surveyList.Find(s => s.Id.Equals(surveyId));

            if (survey != null)
            {
                return survey.DaysSinceAvailable;
            }

            return Constants.NOT_APPLICABLE;
        }


        /// <summary>
        /// Finds the number of days since a historic survey expired.
        /// </summary>
        /// <param name="surveyId">The identifier for the survey</param>
        /// <returns>The number of days since the survey became expired or
        /// NOT_APPLICABLE if the ExpiryDate is not set.</returns>
        public int DaysSinceExpiry(string surveyId)
        {
            var survey = _surveyList.Find(s => s.Id.Equals(surveyId));

            if (survey != null)
            {
                return survey.DaysSinceExpiry;
            }

            return Constants.NOT_APPLICABLE;
        }


        /// <summary>
        /// Finds the number of days since a historic survey was started.
        /// </summary>
        /// <param name="surveyId">The identifier for the survey</param>
        /// <returns>The number of days since the survey became expired or
        /// NOT_APPLICABLE if the StartedDate is not set.</returns>
        public int DaysSinceStarted(string surveyId)
        {
            var survey = _surveyList.Find(s => s.Id.Equals(surveyId));

            if (survey != null)
            {
                return survey.DaysSinceStarted;
            }

            return Constants.NOT_APPLICABLE;
        }


        /// <summary>
        /// Finds the number of days since a historic survey was completed.
        /// </summary>
        /// <param name="surveyId">The identifier for the survey</param>
        /// <returns>The number of days since the survey became expired or
        /// NOT_APPLICABLE if the CompletedDate is not set.</returns>
        public int DaysSinceCompleted(string surveyId)
        {
            var survey = _surveyList.Find(s => s.Id.Equals(surveyId));

            if (survey != null)
            {
                return survey.DaysSinceCompleted;
            }

            return Constants.NOT_APPLICABLE;
        }


    }
}
