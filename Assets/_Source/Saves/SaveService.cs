using Newtonsoft.Json;
using UnityEngine;

namespace _Source.Saves
{
    public class SaveService : ISaveService
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