using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject jTests, jValue;
            var path = "tests.json";
            var path1 = "values.json";

            using (StreamReader reader = new StreamReader(path))
            {
                jTests = JObject.Parse(reader.ReadToEnd());
            }

            using (StreamReader reader = new StreamReader(path1))
            {
                jValue = JObject.Parse(reader.ReadToEnd());
            }

            foreach (var test in jTests["tests"])
            {
                fillValue(test, jValue);
            }

            using (StreamWriter writer = new StreamWriter("report.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, jTests);
            }
            Console.WriteLine("The program has successfully completed the report.json!");
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }

        static void fillValue(JToken jTempTest, JObject jTempValues)
        {
            var value = jTempValues["values"].SelectToken($"[?(@.id == {jTempTest["id"]})]");
            if (value != null)
            {
                jTempTest["value"] = value["value"];
            }
            if ((JArray)jTempTest["values"] != null)
            {
                foreach (var test2 in (JArray)jTempTest["values"])
                {
                    fillValue(test2, jTempValues);
                }
            }
            else return;
        }
    }
}
