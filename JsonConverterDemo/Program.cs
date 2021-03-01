using Newtonsoft.Json;
using System;

namespace JsonConverterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConvert.DefaultSettings = () =>
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };


            var now = DateTime.Now.ToUniversalTime();

            var model = new MyModel
            {
                NormalDateTime = now,
                MyDateTime = now
            };

            var jsonString = JsonConvert.SerializeObject(model);
            Console.WriteLine(jsonString);

            model = JsonConvert.DeserializeObject<MyModel>(jsonString);
            Console.WriteLine(model);
        }
    }
}
