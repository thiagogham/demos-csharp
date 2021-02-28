using System.Xml.Serialization;

namespace MSProjectReadXml
{
    public enum MsProjectDayOfWeek
    {
        [XmlEnum("0")]
        ExceptionDay = 99999,
        [XmlEnum("1")]
        Sunday = 0,
        [XmlEnum("2")]
        Monday = 1,
        [XmlEnum("3")]
        Tuesday = 2,
        [XmlEnum("4")]
        Wednesday = 3,
        [XmlEnum("5")]
        Thursday = 4,
        [XmlEnum("6")]
        Friday = 5,
        [XmlEnum("7")]
        Saturday = 6
    }
}
