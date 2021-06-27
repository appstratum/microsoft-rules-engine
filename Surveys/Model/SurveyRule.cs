using System;


namespace Surveys.Model
{

    /// <summary>
    /// The responsibility of this class is to hold information about a
    /// survey rule definition.
    /// </summary>
    public class SurveyRule
    {
        /// <summary>
        /// The unique identifier for a SurveyRule.
        /// </summary>
        public Guid ID { get; set; }


        /// <summary>
        /// The unique name of a SurveyRule.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// A logical expression that evaluates to true or false.
        /// </summary>
        public string Expression { get; set; }



        /// <summary>
        /// A JSON data structure that describes the action to take.
        /// </summary>
        public string Action { get; set; }


        /// <summary>
        /// The time at which this SurveyRule was created in the database.
        /// </summary>
        public DateTime CreatedAt { get; set; }


        /// <summary>
        /// The time at which this version of this SurveyRule record was
        /// created in the database.
        /// </summary>
        public DateTime ValidFrom { get; set; }


        /// <summary>
        /// The time at which this version of this SurveyRule record
        /// ceased to be valid. If this refers to a time in the future, then
        /// this version of the SurveyRule record is still valid.
        /// </summary>
        public DateTime ValidTo { get; set; }



        public SurveyRule()
        {
            ID = Guid.NewGuid();

            var now = DateTime.UtcNow;

            CreatedAt = now;
            ValidFrom = now;
            ValidTo = DateTime.MaxValue;
        }



        public SurveyRule(
            Guid id,
            string name,
            string expression,
            string action,

            DateTime createdAt,
            DateTime validFrom,
            DateTime validTo)
        {
            ID = id;
            Name = name;
            Expression = expression;
            Action = action;

            CreatedAt = createdAt;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
    }
}
