using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Pizza> ReadJson(string jsonFilePath)
        {
            string jsonString = File.ReadAllText(jsonFilePath); //Read the json file and set it to a string

            return JsonConvert.DeserializeObject<Dictionary<int, Pizza>>(jsonString); //deserializes into our dictionary
        }
    }
}
