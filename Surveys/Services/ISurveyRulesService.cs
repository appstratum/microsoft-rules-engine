using System;
using Surveys.Model;


namespace Surveys.Services
{

    /// <summary>
    /// <para>
    ///     The responsibility of this interface is to define the contract to
    ///     be fulfilled by concrete implementations of a Survey Rules Service.
    /// </para>
    /// <para>
    ///     The Survey Rules Service will be responsible for running survey
    ///     rules in order to build a Survey Schedule, which is made up of
    ///     SurveyScheduleEvents. The RulesSerivc
    /// </para>
    /// </summary>
    public interface ISurveyRulesService
    {

        /// <summary>
        /// <para>
        ///     Read rules from the database and build the internal rules base
        ///     to be used by the rules engine.
        /// </para>
        /// <para>
        ///     This takes place at the start of every execution of the rules
        ///     engine. The RulesBase is loaded from the database initially by
        ///     reading all the rules stored in the database.
        /// </para>
        /// </summary>
        public void RebuildRulesBase();

        /// <summary>
        /// Run the rules base against each particpant for all survey definitions
        /// that have yet to be scheduled for those participants.
        /// </summary>
        public void BuildSurveySchedule();
    }



}
