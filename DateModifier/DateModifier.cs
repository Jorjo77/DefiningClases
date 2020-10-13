using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int GetDayDifference(string firstDateAsString, string secondDateAsString)
        {
            DateTime firstDate = DateTime.Parse(firstDateAsString);
            DateTime secondDate = DateTime.Parse(secondDateAsString);
            double dateDifference = (secondDate - firstDate).TotalDays;
            int result = (int)dateDifference;
            return result;
        }

    }
}
