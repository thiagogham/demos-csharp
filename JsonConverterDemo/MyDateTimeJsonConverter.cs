using Newtonsoft.Json;
using System;

namespace JsonConverterDemo
{
    public class MyDateTimeJsonConverter : JsonConverter<CustomDateTime>
    {
        public override CustomDateTime ReadJson(
            JsonReader reader,
            Type objectType,
            CustomDateTime existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            if(reader.Value != null)
                return (DateTime)reader.Value;

            return null;
        }

        public override void WriteJson(
            JsonWriter writer,
            CustomDateTime value,
            JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
