using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Calendar")]
    public class Calendar
    {
        public int UID { get; set; }

        public string Name { get; set; }

        public string GUID { get; set; }

        public int IsBaseCalendar { get; set; }

        public int IsBaselineCalendar { get; set; }

        public int BaseCalendarUID { get; set; }

        public List<WeekDay> WeekDays { get; set; }

        public List<WorkWeek> WorkWeeks { get; set; }

        public IEnumerable<WeekDayWithWorkingTime> GetWeekDaysWithWorkingTimes()
        {
            IList<WeekDayWithWorkingTime> weekDayWithWorkingTime = new List<WeekDayWithWorkingTime>();

            if (this.WeekDays.Count > 0)
            {
                foreach (var weekDay in this.WeekDays.Where(day => day.DayWorking == 1))
                {
                    if (weekDay.WorkingTimes.Count > 0)
                    {
                        weekDay.WorkingTimes.ForEach(time =>
                            weekDayWithWorkingTime.Add(new WeekDayWithWorkingTime
                            {
                                DayType = weekDay.DayType,
                                FromTime = time.FromTimeSpan,
                                ToTime = time.ToTimeSpan
                            })
                        );
                    }
                }
            }

            return weekDayWithWorkingTime;
        }
    }
}
