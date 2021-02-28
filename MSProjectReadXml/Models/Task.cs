using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Task")]
    public class Task
    {
        public int ID { get; set; }

        public int UID { get; set; }

        public string Name { get; set; }

        public bool Manual { get; set; }

        public DateTime CreateDate { get; set; }

        public string WBS { get; set; }

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        [XmlElement("PredecessorLink")]
        public List<PredecessorLink> Predecessors { get; set; }

        [XmlElement("ExtendedAttribute")]
        public List<ExtendedAttribute> ExtendedAttribute { get; set; }

        [XmlIgnore]
        public Dictionary<string, object> ExtendedAttributesDictionary { get; set; }

        public void AddAttributeDictionary(string name, object value)
        {
            this.ExtendedAttributesDictionary ??= new Dictionary<string, object>();
            this.ExtendedAttributesDictionary[name] = value;
        }
    }
}
