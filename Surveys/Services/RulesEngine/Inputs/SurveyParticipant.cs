using System;


namespace Surveys.Services.RulesEngine.Input
{

    /// <summary>
    /// The responsibility of this class is to hold information about a
    /// Participant.
    /// </summary>
    public class SurveyParticipant
    {
        public ParticipantRegistration Registration { get; set; }
        public SurveyHistory PreviousSurveys { get; set; }

        public SurveyParticipant()
        {

        }

        public SurveyParticipant(
            ParticipantRegistration registration,
            SurveyHistory previousSurveys)
        {
            Registration = registration;
            PreviousSurveys = previousSurveys;
        }
    }
}
