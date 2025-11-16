using CalculatorModule.Domain.Entities;
using Newtonsoft.Json;
using UnityEngine;

namespace CalculatorModule.Infrastructure.Repositories
{
    public class SaveService : Domain.Repositories.ISaveService
    {
        public void Save<T>(string key ,T value)
        {
            string json = JsonConvert.SerializeObject(value);
            PlayerPrefs.SetString(key, json);
            PlayerPrefs.Save();
        }

        public T  Load<T>(string key,T value)
        {
            string json = PlayerPrefs.GetString(key, string.Empty);
            return string.IsNullOrEmpty(json) ? value : JsonConvert.DeserializeObject<T>(json);
        }
    }
}