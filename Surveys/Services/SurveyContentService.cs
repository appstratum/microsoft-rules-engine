using System;
using Surveys.Model;


namespace Surveys.Services
{

    /// <summary>
    /// The responsibility of this service is to provide access to
    /// survey-related content that originated in a remote content management
    /// system.
    /// </summary>
    public class SurveyContentService : ISurveyContentService
    {


        // TODO: Inject any data access logic such as readers or writers here.
        // This is more flexible for testing because they can be easily mocked.
        public SurveyContentService()
        {

        }


        // Implement methods here that contain business logic for
        // retrieving Survey Definitions from the Rarify database.

        public SurveyDefinition RetrieveSurveyDefinition(Guid surveyDefinitionId)
        {
            throw new NotImplementedException();
        }
    }
}
