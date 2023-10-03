using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using crypto;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class UserDataAccess : IUserDataAccess
    {
        private static readonly string rootDirectory = Directory.GetParent(path: Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        public static readonly string settingsFile = Path.Combine(rootDirectory, "Databases", "settings.json");

        public bool Create(User user)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "insert into user (firstName, lastName, phoneNumber, email, username, password, hashed_password, salt,image_id) " +
                        "values (@firstName, @lastName, @phoneNumber, @email, @username, @password, @hashedPassword, @salt, @imageId)";

                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", user.LastName);
                    cmd.Parameters.AddWithValue("@phoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Sorry, the account COULD NOT be created currently. Please try again later!");
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }










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
