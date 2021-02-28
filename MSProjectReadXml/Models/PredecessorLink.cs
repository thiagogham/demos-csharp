using System.Xml;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("PredecessorLink")]
    public class PredecessorLink
    {
        [XmlElement("PredecessorUID")]
        public int PredecessorUID { get; set; }

        [XmlElement("Type")]
        public int Type { get; set; }

        [XmlElement("LinkLag")]
        public int LinkLag { get; set; }

        [XmlElement("CrossProject")]
        public int CrossProject { get; set; }

        [XmlElement("LagFormat")]
        public int LagFormat { get; set; }
    }
}
