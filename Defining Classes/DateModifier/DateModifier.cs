using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {


        public static int DateDifference(string startDateAsString, string endDateAsString)
        {

            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);
            var diff = endDate - startDate;

            return Math.Abs(diff.Days);
        }
    }

}
