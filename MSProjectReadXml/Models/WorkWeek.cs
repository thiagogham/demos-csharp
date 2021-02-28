using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("WorkWeek")]
    public class WorkWeek
    {
        public string Name { get; set; }

        public TimePeriod TimePeriod { get; set; }

        public List<WeekDay> WeekDays { get; set; }

        public IList<WeekDayWithWorkingTime> GetWeekDaysWithWorkingTimes()
        {
            IList<WeekDayWithWorkingTime> weekDayWithWorkingTime = new List<WeekDayWithWorkingTime>();

            if (this.WeekDays.Count > 0)
            {
                var daysWork = this.WeekDays.Where(day => day.DayWorking == 1).ToList();

                daysWork.ForEach(item =>
                {
                    item.WorkingTimes.ForEach(time =>
                        weekDayWithWorkingTime.Add(new WeekDayWithWorkingTime
                        {
                            DayType = item.DayType,
                            FromTime = time.FromTimeSpan,
                            ToTime = time.ToTimeSpan
                        })
                    );
                });
            }
            return weekDayWithWorkingTime;
        }
    }
}
