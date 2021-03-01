using System;
using System.Runtime.Serialization;

namespace JsonConverterDemo
{
    [DataContract]
    public class MyModel
    {
        [DataMember]
        public DateTime NormalDateTime { get; set; }

        [DataMember]
        public CustomDateTime MyDateTime { get; set; }

        [DataMember]
        public CustomDateTime? MyNullableDateTime { get; set; }
    }
}
