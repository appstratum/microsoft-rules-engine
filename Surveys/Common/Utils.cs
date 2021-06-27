using System;
namespace SurveyRulesEngine.Common
{
    public static class Utils
    {
        public static bool IsSet(DateTime date)
        {
            return !Constants.NEVER.Equals(date);
        }


        /// <summary>
        /// The number of days since the specified date or -1 if the date is
        /// equal to Constants.NOT_SET.
        /// </summary>
        public static int DaysSince(DateTime date)
        {
            if (IsSet(date))
            {
                var timespan = DateTime.UtcNow.Subtract(date);

                return timespan.Days;
            }
            return Constants.NOT_APPLICABLE;
        }


        /// <summary>
        /// The number of days until the specified date or -1 if the date is
        /// equal to int.MaxValue.
        /// </summary>
        public static int DaysUntil(DateTime date)
        {
            if (IsSet(date))
            {
                var timespan = date.Subtract(DateTime.UtcNow);

                return timespan.Days;
            }
            return Constants.MAX_DAYS;
        }
    }
}
