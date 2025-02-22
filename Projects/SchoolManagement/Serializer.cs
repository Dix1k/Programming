using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;


namespace SchoolManagement
{
    public static class Serializer
    {
        public static void SerializeToFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonData);
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return default;

            string jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
