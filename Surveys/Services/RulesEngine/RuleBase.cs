using System;
using System.Collections.Generic;
using RulesEngine.Models;

using Surveys.Model;

namespace Surveys.Services.RulesEngine
{

    /// <summary>
    /// <para>
    ///     The responsibility of this class is to organise the different kinds
    ///     of rules.
    /// </para>
    /// </summary>
    public class RuleBase
    {

        private readonly List<Rule> _availabilityRules;

        private readonly List<Rule> _expiryRules;

        public RuleBase(IList<SurveyRule> persistedRules)
        {

            // TODO: Convert SurveyRule to Rule objects that can be used
            // directly by the Microsoft rule engine. The SurveyRule objects
            // will be retrieved by the SurveyRuleService and used to
            // instantiate this RuleBase object.

            // TODO: filter these into two categories:
            // - availability rules
            // - expiry rules

            // Note that AvailabilityRules will be run before ExpiryRules. This
            // is because the ExpiryDate may be dependent (and probably is) on
            // the AvailabilityDate.

            // Only after both sets of rules (AvailabilityRules and ExpiryRules)
            // have run for any given participant and survey combination will
            // the SurveyScheduleEvents that are created be persisted in the
            // database.
        }


        public Rule[] AvailabilityRules
        {
            get
            {
                return _availabilityRules.ToArray();
            }
        }


        public Rule[] ExpiryRules
        {
            get
            {
                return _expiryRules.ToArray();
            }
        }
    }
}
