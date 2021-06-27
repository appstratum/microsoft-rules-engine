using System;
using System.Collections.Generic;

using Surveys.Model;

namespace Surveys.Services
{

    /// <summary>
    /// <para>
    ///     The responsibility of this interface is to defined the contract that
    ///     must be filled by services that are responsible for managing the
    ///     availablity of survey content to end users.
    /// </para>
    /// <para>
    ///     The visibility of surveys to end users will vary by role, permissions
    ///     and will also vary over time as survey rules are applied to make
    ///     survey definitions available and expired.
    /// </para>
    /// </summary>
    public interface ISurveyManagementService
    {

        // List operation signatures here. Implement them in a concrete service.


        /// <summary>
        /// SurveyScheduleEvents contain references to the Participant ID, the
        /// SurveyDefinition ID, AvailbilityDate and ExpiryDate. The goal
        /// of this method is to retrieve SurveyScheduleEvents of a single
        /// Participant.
        /// </summary>
        /// 
        /// <param name="participantId">The unique identifier for the
        /// partcipant for whom the scheduled surveys are being retrieved.</param>
        ///
        /// <returns>A list of SurveyScheduleEvents or an empty list if no
        /// surveys are available for this user.</returns>
        public IList<SurveyScheduleEvent> RetrieveSurveysScheduledFor(Guid participantId, object somePaginationObject);


        /// <summary>
        /// SurveyScheduleEvents contain references to the Participant ID, the
        /// SurveyDefinition ID, AvailbilityDate and ExpiryDate. The goal
        /// of this method is to retrieve SurveyScheduleEvents for multiple
        /// Participants.
        /// </summary>
        /// 
        /// <param name="participantId">The unique identifier for the
        /// partcipant for whom the scheduled surveys are being retrieved.</param>
        ///
        /// <returns>A list of SurveyScheduleEvents or an empty list if no
        /// surveys are available for this user.</returns>
        public IList<SurveyScheduleEvent> RetrieveSurveysScheduledFor(IList<Guid> participantIds, object somePaginationObject);


    }
}
