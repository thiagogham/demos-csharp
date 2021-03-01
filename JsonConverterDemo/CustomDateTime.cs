using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace JsonConverterDemo
{
    [JsonConverter(typeof(MyDateTimeJsonConverter))]
    [DataContract]
    public struct CustomDateTime
    {
        [DataMember(Order = 1)]
        public long DateTimeTicks { get; private set; }

        public static implicit operator CustomDateTime(DateTime value) =>
            new CustomDateTime
            {
                DateTimeTicks = value.ToUniversalTime().Ticks
            };

        public static implicit operator CustomDateTime?(DateTime? value)
        {
            if (value.HasValue)
            {
                return new CustomDateTime
                {
                    DateTimeTicks = value.Value.ToUniversalTime().Ticks
                };
            }

            return null;
        }


        public static implicit operator CustomDateTime(string value) =>
            new CustomDateTime
            {
                DateTimeTicks = Convert.ToDateTime(value).ToUniversalTime().Ticks
            };

        public static implicit operator DateTime(CustomDateTime value) =>
            new DateTime(value.DateTimeTicks).ToLocalTime();

        public static implicit operator DateTime?(CustomDateTime? value)
        {
            if (value.HasValue)
                return new DateTime(value.Value.DateTimeTicks).ToLocalTime();

            return null;
        }

        public static implicit operator string(CustomDateTime value) =>
            value.ToString();

        public override string ToString() =>
            new DateTime(this.DateTimeTicks).ToLocalTime().ToString("O");
    }
}
