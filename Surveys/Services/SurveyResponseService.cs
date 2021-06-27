using System;
using Surveys.Model;

namespace Surveys.Services
{


    /// <summary>
    /// <para>
    ///     The responsibility of this class is to manage access to survey
    ///     responses.
    /// </para>
    /// <para>
    ///     Survey responses will be stored in at least two places. First of
    ///     all, for responses that contain only PHI data, the response will
    ///     simply be stored in the SurveyResponsses table of the Rarify
    ///     PHI Data Vault database - the study database, in other words. For
    ///     responses that contain PII content, the responses will be stored
    ///     in another location such as the PII Data Vault.
    /// </para>
    /// <para>
    ///     The value of the Survey Response Service in this context is to
    ///     orchestrate the storage and retrieval operations across multiple
    ///     data stores and to ensure the transactional integrity of these
    ///     operations.
    /// </para>
    /// <para>
    ///     Another important element of the responsibilities of a Survey
    ///     Response service is validation. For example, the response models
    ///     should be valid JSON an not empty.
    /// </para>
    /// </summary>
    public class SurveyResponseService : ISurveyResponseService
    {

        // TODO: Inject any data access logic such as readers or writers here.
        // This is more flexible for testing because they can be easily mocked.
        public SurveyResponseService()
        {
        }


        /// <inheritdoc>
        public SurveyResponse RetrieveResponse(Guid responseId)
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc>
        public Guid StoreResponse(Guid participantId, Guid surveyDefinitionId, string responseModel, bool completed)
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc>
        public Guid UpdateResponse(Guid responseId, string responseModel, bool completed)
        {
            throw new NotImplementedException();
        }
    }
}
