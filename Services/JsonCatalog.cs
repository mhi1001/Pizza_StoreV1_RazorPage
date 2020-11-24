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
            
        }

        public Dictionary<int, Pizza> GetAllPizzas()
        {
            return JsonFileReader.ReadJson(filePath);
        }

        public void AddPizza(Pizza pizza)
        {
            //Created a dictionary that calls the GetAllPizzas so it populates it with the existing pizzas.
            //then we add the new pizza to it, and then afterwards write to Json the created dictionary (existingPizzas)
            //Dictionary<int, Pizza> existingPizzas = GetAllPizzas();
            Pizzas = GetAllPizzas();

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
