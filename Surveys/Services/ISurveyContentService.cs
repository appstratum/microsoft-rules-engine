using System;

using Surveys.Model;

namespace Surveys.Services
{

    /// <summary>
    /// The responsibility of this service is to provide access to
    /// survey-related content that originated in a remote content management
    /// system.
    /// </summary>
    public interface ISurveyContentService
    {
        // List operation signatures here. Implement them in a concrete service.


        /// <summary>
        /// <para>
        ///     The goal of this operation is to retrieve the SurveyDefinition
        ///     with the specified ID.
        /// </para>
        /// </summary>
        /// <param name="surveyDefinitionId">The unique identifier for the
        /// SurveyDefinition to be retrieved</param>
        /// <returns>A SurveyDefinition object or null if no matching survey
        /// definition can be found.</returns>
        public SurveyDefinition RetrieveSurveyDefinition(Guid surveyDefinitionId);

    }
}
