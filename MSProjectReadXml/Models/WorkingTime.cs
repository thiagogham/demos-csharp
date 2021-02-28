using System;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("WorkingTime")]
    public class WorkingTime
    {
        private string _fromTime;

        [XmlIgnore]
        public TimeSpan FromTimeSpan
        {
            get => TimeSpan.Parse(_fromTime);
            set => _fromTime = value.ToString();
        }

        private string _toTime;

        [XmlIgnore]
        public TimeSpan ToTimeSpan
        {
            get =>  TimeSpan.Parse(_toTime);
            set =>  _toTime = value.ToString();
        }
    }
}
