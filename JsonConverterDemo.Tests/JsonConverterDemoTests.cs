using Newtonsoft.Json;
using System;
using Xunit;

namespace JsonConverterDemo.Tests
{
    public class JsonConverterDemoTests
    {
        public JsonConverterDemoTests()
        {
            JsonConvert.DefaultSettings = () =>
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
        }

        private string StringDate => "2021-02-28T22:10:40";
        private DateTime Date => DateTime.Parse(StringDate);
        private MyModel Model => new MyModel
        {
            NormalDateTime = Date,
            MyDateTime = Date
        };

        [Fact]
        public void should_json_string_contains_string_date()
        {
            //Arrange 
            //Act  
            var jsonString = JsonConvert.SerializeObject(Model);

            //Assert
            Assert.Contains(StringDate, jsonString);
        }

        [Fact]
        public void should_maintain_same_property_after_deserialization()
        {
            //Arrange 
            //Act  
            var jsonString = JsonConvert.SerializeObject(Model);
            var newModel = JsonConvert.DeserializeObject<MyModel>(jsonString);

            //Assert
            Assert.Equal(Model.MyDateTime, newModel.MyDateTime);
        }
    }
}
