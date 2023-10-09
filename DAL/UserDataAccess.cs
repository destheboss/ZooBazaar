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
using BLL.Models;
using ClassLibrary.Extentions;

namespace DAL
{
    public class UserDataAccess : IUserDataAccess
    {
        private static readonly string rootDirectory = Directory.GetParent(path: Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        public static readonly string settingsFile = Path.Combine(rootDirectory, "Forms", "settings.json");

        public bool CreateEmployee(Employee employee)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "INSERT INTO employee (id, email, password, firstName, lastName, birthDate, phoneNumber, bsn, wage, role, city, street, zipCode, houseNumber) " +
                        "values (@id, @email, @password, @firstName, @lastName, @birthDate, @phoneNumber, @bsn, @wage, @role, @city, @street, @zipCode, @houseNumber)";

                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@password", employee.Password);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@birthdate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@bsn", employee.Bsn);
                    cmd.Parameters.AddWithValue("@wage", employee.Wage);
                    cmd.Parameters.AddWithValue("@role", employee.Role);
                    cmd.Parameters.AddWithValue("@city", employee.City);
                    cmd.Parameters.AddWithValue("@street", employee.Street);
                    cmd.Parameters.AddWithValue("@zipCode", employee.ZipCode);
                    cmd.Parameters.AddWithValue("@houseNumber", employee.HouseNumber);
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

        public bool CreateCustomer(Customer customer)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "INSERT INTO customer (id, email, password, firstName, lastName, birthDate, phoneNumber, age) " +
                        "values (@id, @email, @password, @firstName, @lastName, @birthDate, @phoneNumber, @age)";

                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@id", customer.Id);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@password", customer.Password);
                    cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@birthdate", customer.BirthDate);
                    cmd.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                    cmd.Parameters.AddWithValue("@age", customer.Age);
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

        public bool CheckLogIn(string email, string password, out int id)
        {

            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "select * FROM employee WHERE email = @email AND password = @password";
                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        return true;
                    }
                    else
                    {
                        id = 0;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    id = 0;
                    return false;
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }
        public Employee? GetEmployeeById(int id)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                    Conn.Open();
                    string sql = "select * FROM employee WHERE id = @Id";
                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@Id", id);

                    var reader = cmd.ExecuteReader();

                    var columns = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        columns.Add(reader.GetName(i));
                    }

                    if (reader.Read())
                    {
                        Employee employee = new Employee(
                            reader.GetInt32("id"),
                            reader.GetString("email"),
                            reader.GetString("password"),
                            reader.GetString("firstName"),
                            reader.GetString("lastName"),
                            reader.GetDateTime("birthDate"),
                            reader.GetInt32("phoneNumber"),
                            reader.GetInt32("bsn"),
                            reader.GetInt32("wage"),
                            Extentions.ParseEnum<Role>(reader.GetString(9)),
                            reader.GetString("city"),
                            reader.GetString("street"),
                            reader.GetString("zipCode"),
                            reader.GetString("houseNumber"));
                        return employee;
                    }
                    return null;
                try
                {
                }
                catch (Exception ex)
                {
                    throw ex;
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
