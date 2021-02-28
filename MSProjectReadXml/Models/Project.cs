using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Project")]
    public class Project
    {
        public int SaveVersion { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public int CalendarUID { get; set; }

        public List<ExtendedAttribute> ExtendedAttributes { get; set; }

        public List<Calendar> Calendars { get; set; }

        public List<Resource> Resources { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
