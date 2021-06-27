using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Surveys.Services;

    /// <summary>
    /// The responsibility of this class is to orchestrate retrieval of
    /// survey content from the database.
    /// </summary>
    [ApiController]
    public class SurveyManagementController : ControllerBase
    {


        private readonly ILogger<SurveyContentController> _logger;
        private readonly ISurveyManagementService _surveyManagementService;


        public SurveyManagementController(ILogger<SurveyContentController> logger, ISurveyManagementService surveyManagementService)
        {
            _logger = logger;
            _surveyManagementService = surveyManagementService;
        }


        // TODO: Add APIs as per requirements (but please follow the general
        // pattern of the example below. Rarify controllers are currently
        // not well structure. Some are very fat (with business logic that
        // should really be in a service, as shown below). Others are ok but
        // call data access logic directly, which is inflexible.
        //
        // Ideally all interactions with the database should be via a service
        // (as per the architectural design for Rarify) and this is easier
        // to properly unit test than the controllers (because controllers can
        // only adequately be tested within an MVC pipeline, which we don't do
        // in unit tests). Controllers are best tested using Integration Testing
        // rather than unit testing.
        //
        // Please also note that the Controller is responsible for orchestrating
        // the business services and translating in input from HTTP and output
        // to HTTP with the appropriate status codes. It should be doing nothing
        // more than that.
        //
        // If the controller is doing more than this then it is the "Doing"
        // thing rather than the "Controlling" thing. The Services are there to
        // "Do" things (and are portable... they can be used outside of a web app
        // or API app). The Controllers are here simply to "Control" access to
        // the services and to act as "HTTP" adapters between HTTP clients and
        // the business services that serve the client's needs.



        /// <summary>
        /// The goal of this API is to return a list of surveys scheduled
        /// for the participant.
        /// </summary>
        /// <param name="participantId">the unique identifier for a Participant
        /// </param>
        /// <returns>A list of scheduled events.</returns>

        [HttpGet]
        [Route("/api/survey/participant/{participantId}/scheduled")]
        //[Authorize(Roles = "Study Monitor, Medical Monitor")] // Authorize roles/permissions as per requirements
        //[NoTransaction]  // Apply transaction attributes when integrated with Rarify.
        public IActionResult GetScheduledSurveysFor(Guid participantId)
        {

            // TODO: Modifify this implementation to include support for pagination.
            // This requires update of the API and the service. Use patters
            // already used in other Rarify APIs. Pedro Vaz: please speak to
            // Rui Guerra for guidance on his preferred approach.

            var scheduledSurveys =
                _surveyManagementService.RetrieveSurveysScheduledFor(participantId, null);

            if (scheduledSurveys.Count > 0)
            {
                return Ok(scheduledSurveys.ToArray());
            } else
            {
                return NotFound();
            }

        }


    }
}
