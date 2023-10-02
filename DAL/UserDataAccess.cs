using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDataAccess : IUserDataAccess
    {
        private static readonly string rootDirectory = Directory.GetParent(path: Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        public static readonly string settingsFile = Path.Combine(rootDirectory, "Databases", "settings.json");














        //NEEDED FOR USER AUTHENTICATION DESKTOP
        public void SetSetting(string key, dynamic? value)
        {
            // read file as text
            using StreamReader reader = new StreamReader(settingsFile);
            string json = reader.ReadToEnd();
            reader.Close();

            // text -> object
            JsonNode? data = JsonNode.Parse(json);

            data![key] = value;

            // write the new value to the file
            using StreamWriter writer = new StreamWriter(settingsFile);
            writer.Write(JsonSerializer.Serialize(data));
            writer.Close();
        }
        public dynamic? GetSetting(string key)
        {
            // read the file as text
            using StreamReader reader = new StreamReader(settingsFile);
            string json = reader.ReadToEnd();
            reader.Close();

            // text -> object
            JsonNode? data = JsonNode.Parse(json);

            if (data!.AsObject().ContainsKey(key)) return data[key];

            return null;
        }
    }
}
