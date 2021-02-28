using System;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("TimePeriod")]
    public class TimePeriod
    {
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}
