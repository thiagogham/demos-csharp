using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Calendars")]
    public class Calendars
    {
        public List<Calendar> Calendar { get; set; }
    }
}
