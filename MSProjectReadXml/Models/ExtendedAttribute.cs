using System.Xml.Serialization;

namespace MSProjectReadXml
{
    [XmlType("ExtendedAttribute")]
    public class ExtendedAttribute
    {
        public int FieldID { get; set; }

        public string FieldName { get; set; }

        public string Alias { get; set; }

        public string Value { get; set; }
    }
}
