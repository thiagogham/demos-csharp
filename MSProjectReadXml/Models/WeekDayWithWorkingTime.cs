using System;

namespace MSProjectReadXml
{
    public class WeekDayWithWorkingTime
    {
        public MsProjectDayOfWeek DayType { get; set; }

        public TimeSpan FromTime { get; set; }

        public TimeSpan ToTime { get; set; }
    }
}
