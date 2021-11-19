using Newtonsoft.Json;
using ReadJsonTaskWithSemaphore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonTaskWithSemaphore.Json
{
    public class JsonHelper
    {
        public const string fileName = "1.json";
        public static void JSONSerialization(Car database)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, database);
                }
            }
        }
        public static void JSONDeSerialization(ref Car database)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    database = serializer.Deserialize<Car>(jsonTextReader);
                }
            }
        }
    }
}
