using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToJson(Dictionary<int, Pizza> pizzas, string jSonFilePath)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(pizzas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jSonFilePath, output);
        }
    }
}
