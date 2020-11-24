using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Models;
using Newtonsoft.Json;

namespace Pizza_StoreV1.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToJson(Dictionary<int, Pizza> pizzas, string jSonFilePath)
        {
            string output = JsonConvert.SerializeObject(pizzas, Formatting.Indented);
            File.WriteAllText(jSonFilePath, output);
        }
    }
}
