using System;

using Surveys.Model;

namespace Surveys.Services
{

    /// <summary>
    /// <para>
    ///     The responsibility of this interface is to defined the contract that
    ///     should be implemented by concrete implementations of a Survey Response
    ///     service.
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
    public interface ISurveyResponseService
    {

        /// <summary>
        /// <para>
        ///     The goal of this operation is to store a response model in
        ///     the appropriate data store.
        /// </para>
        /// <para>
        ///     A response will be stored with references to the Participant ID
        ///     and Survey Definition ID in order to ensure that that there is
        ///     sufficient context to replay the survey response in future.
        ///     The response model is a JSON document and is stored as a text
        ///     string. A completed flag is used to 
        /// </para>
        /// </summary>
        /// <param name="participantId">The unique identifier for the Participant
        /// that responded to the survey.</param>
        /// <param name="surveyDefinitionId">The unique identifier of the
        /// survey model that contained the survey questions.</param>
        /// <param name="responseModel">The JSON document that contains the
        /// Participant's answers</param>
        /// <param name="completed">A flag to indicate whether or not
        /// the responses are complete.</param>
        /// <returns>The unique identifer the stored response.</returns>
        public Guid StoreResponse(Guid participantId, Guid surveyDefinitionId, string responseModel, bool completed);

        /// <summary>
        /// <para>
        ///     The goal of this operation is to store a response model in
        ///     the appropriate data store.
        /// </para>
        /// <para>
        ///     A response will be stored with references to the Participant ID
        ///     and Survey Definition ID in order to ensure that that there is
        ///     sufficient context to replay the survey response in future.
        ///     The response model is a JSON document and is stored as a text
        ///     string. A completed flag is used to 
        /// </para>
        /// </summary>
        /// <param name="responseId">The unique identifier for the response.
        /// </param>
        /// <param name="responseModel">The JSON document that contains the
        /// Participant's answers</param>
        /// <param name="completed">A flag to indicate whether or not
        /// the responses are complete.</param>
        /// <returns>The unique identifer the stored response.</returns>
        public Guid UpdateResponse(Guid responseId, string responseModel, bool completed);


        /// <summary>
        /// <para>
        ///     Retrieves a SurveyResponse from the underlying data stores.
        /// </para>
        /// </summary>
        /// <param name="responseId">The unique identifier of a survey response.
        /// </param>
        /// <returns></returns>
        public SurveyResponse RetrieveResponse(Guid responseId);



        // TODO: Add other operations to find and retrieve responses or
        // report on responses or response histories. Then implement these in
        // the concrete class that implements this interface.


    }
}
