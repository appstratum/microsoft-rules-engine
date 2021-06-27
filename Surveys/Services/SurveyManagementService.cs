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
    public class SurveyManagementService : ISurveyManagementService
    {



        // TODO: Inject any data access logic such as readers or writers here.
        // This is more flexible for testing because they can be easily mocked.
        public SurveyManagementService()
        {
        }


        /// <inheritdoc/>
        public IList<SurveyScheduleEvent> RetrieveSurveysScheduledFor(Guid participantId, object somePaginationObject)
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc/>
        public IList<SurveyScheduleEvent> RetrieveSurveysScheduledFor(IList<Guid> participantIds, object somePaginationObject)
        {
            throw new NotImplementedException();
        }
    }
}
