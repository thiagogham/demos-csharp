using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("Resource")]
    public class Resource
    {
        public int UID { get; set; }

        public int ID { get; set; }

        public int Type { get; set; }
    }
}
