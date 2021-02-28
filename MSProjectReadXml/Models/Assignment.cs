using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Assignment")]
    public class Assignment
    {
        public int UID { get; set; }

        public int TaskUID { get; set; }

        public int ResourceUID { get; set; }
    }
}
