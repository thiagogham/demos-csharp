using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("WeekDay")]
    public class WeekDay
    {
        [XmlElement(Type = typeof(MsProjectDayOfWeek))]
        public MsProjectDayOfWeek DayType { get; set; }

        public int DayWorking { get; set; }

        public List<WorkingTime> WorkingTimes { get; set; }
    }
}
