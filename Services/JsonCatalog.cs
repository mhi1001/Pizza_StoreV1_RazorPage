using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pizza_StoreV1.Helpers;
using Pizza_StoreV1.Interfaces;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Services
{
    public class JsonCatalog : IPizzaRepository
    {
        private string filePath = @".\Data\JsonPizzas.json";
        private Dictionary<int, Pizza> Pizzas { get; set; }
        
        public JsonCatalog()
        {
            Pizzas = AllPizzas();
        }

        public Dictionary<int, Pizza> AllPizzas()
        {
            Pizzas = JsonFileReader.ReadJson(filePath);
            return Pizzas;
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza.Id,pizza);
            JsonFileWriter.WriteToJson(Pizzas,filePath);
        }
        public Pizza GetPizza(int id)
        {
            return null;
        }

        public void UpdatePizza(int id, Pizza @p)
        {
            
        }

        public void RemovePizza(int id)
        {
            
        }

        public Dictionary<int, Pizza> FilterPizzas(string criteria)
        {
         

            return null;
        }
    }
}
