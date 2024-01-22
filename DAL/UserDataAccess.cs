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
using BLL.Models.AutoSchedule;

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
                    string sql = "INSERT INTO employee (id, email, password, firstName, lastName, phoneNumber, bsn, wage, role, city, street, zipCode, houseNumber, contractId) " +
                        "values (@id, @email, @password, @firstName, @lastName, @phoneNumber, @bsn, @wage, @role, @city, @street, @zipCode, @houseNumber,@contractId)";

                    var cmd = new MySqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@password", employee.Password);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@bsn", employee.Bsn);
                    cmd.Parameters.AddWithValue("@wage", employee.Wage);
                    cmd.Parameters.AddWithValue("@role", employee.Role);
                    cmd.Parameters.AddWithValue("@city", employee.City);
                    cmd.Parameters.AddWithValue("@street", employee.Street);
                    cmd.Parameters.AddWithValue("@zipCode", employee.ZipCode);
                    cmd.Parameters.AddWithValue("@houseNumber", employee.HouseNumber);
                    cmd.Parameters.AddWithValue("@contractId", employee.ContractId);

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
                            reader.GetInt32("phoneNumber"),
                            reader.GetInt32("bsn"),
                            reader.GetInt32("wage"),
                            Extentions.ParseEnum<Role>(reader.GetString("role")),
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
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();

                    string sql = "select * FROM employee";
                    var cmd = new MySqlCommand(sql, Conn);
                    var reader = cmd.ExecuteReader();

                    List<Employee> employees = new List<Employee>();
                    while (reader.Read())
                    {
                        Employee employee = new Employee(
                             reader.GetInt32("id"),
                            reader.GetString("email"),
                            reader.GetString("password"),
                            reader.GetString("firstName"),
                            reader.GetString("lastName"),
                            reader.GetInt32("phoneNumber"),
                            reader.GetInt32("bsn"),
                            reader.GetInt32("wage"),
                            Extentions.ParseEnum<Role>(reader.GetString("role")),
                            reader.GetString("city"),
                            reader.GetString("street"),
                            reader.GetString("zipCode"),
                            reader.GetString("houseNumber"));
                        employees.Add(employee);
                    }
                    return employees;
                }
                catch (InvalidOperationException)
                {
                    return new List<Employee>();
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }
        public bool UpdateEmployee(Employee employee)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    string sql = "UPDATE employee SET firstName = @firstName, lastName = @lastName, phoneNumber = @phoneNumber, email = @email, wage = @wage WHERE id = @userId";
                    var cmd = new MySqlCommand(sql, Conn);
                    Conn.Open();

                    cmd.Parameters.AddWithValue("@userId", employee.Id);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@wage", employee.Wage);
                    int result = cmd.ExecuteNonQuery();
                    return result == 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }

        public void EmployeeSelfUpdate(int Id, string Email, int PhoneNumber, string City, string Street, string ZipCode, string HouseNumber)
        {
            MySqlCommand msqlcd;
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    string query = "UPDATE employee SET email = @email, phoneNumber = @phoneNumber, city = @city, street = @street, zipCode = @zipCode, houseNumber = @houseNumber WHERE id = @id";

                    msqlcd = new MySqlCommand(query, conn);
                    msqlcd.Parameters.AddWithValue("@id", Id);
                    msqlcd.Parameters.AddWithValue("@email", Email);
                    msqlcd.Parameters.AddWithValue("@phoneNumber", PhoneNumber);
                    msqlcd.Parameters.AddWithValue("@city", City);
                    msqlcd.Parameters.AddWithValue("@street", Street);
                    msqlcd.Parameters.AddWithValue("@zipCode", ZipCode);
                    msqlcd.Parameters.AddWithValue("@houseNumber", HouseNumber);
                    conn.Open();
                    msqlcd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public bool DeleteEmployee(int id)
        {
            //bool success = false;
            using (MySqlConnection conn = ConnectionString.Connection())
            {
                conn.Open();
                string sqlEmp = "DELETE FROM employee WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sqlEmp, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                return true;
                try
                {

                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public List<int> GetEmployeeswithleastshifts(DateTime startofweek)
        {
            MySqlConnection Conn = ConnectionString.Connection();
            List<int> employeeids = new List<int>();
            try
            {
                using (Conn)
                {
                    string sql = "select e.id, COALESCE(t.total,0) as amountofshifts from employee as e left JOIN (SELECT se.employeeid as empid,COUNT(se.employeeid)as total FROM `shift_has_employee` as se inner join shift as s on s.ID = se.shiftid where Date(date) between @date and @enddate GROUP by se.employeeid) t ON t.empid = e.id order by amountofshifts;";
                    MySqlCommand cmd = new MySqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@date", startofweek);
                    cmd.Parameters.AddWithValue("@enddate", startofweek.AddDays(7));
                    Conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        employeeids.Add(Convert.ToInt32(dr[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return employeeids;
        }

        public List<Employee> GetAllAvailableEmployees(Shift shift)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "SELECT employee.* FROM employee WHERE employee.Id NOT IN (SELECT employeeid FROM shift_has_employee where shiftid = @shiftid)";
                    var cmd = new MySqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@shiftId", shift.Id);
                    var reader = cmd.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (reader.Read())
                    {
                        //Extentions.ParseEnum<Role>(reader.GetString(9));
                        //Employee employee = new Employee(
                        //    reader.GetInt32(0),
                        //    reader.GetString(1),
                        //    reader.GetString(2),
                        //    reader.GetInt32(3),
                        //    reader.GetString(4),
                        //    reader.GetString(8),
                        //    reader.GetInt32(5),
                        //    reader.GetString(6),
                        //    reader.GetInt32(7),
                        //    Extentions.ParseEnum<Role>(reader.GetString(9)),
                        //    reader.GetString(10),
                        //    reader.GetString(11),
                        //    reader.GetInt32(12),
                        //    reader.GetString(13),
                        //    reader.GetInt32(14));
                        //employees.Add(employee);
                        Employee employee = new Employee(
                             reader.GetInt32("id"),
                            reader.GetString("email"),
                            reader.GetString("password"),
                            reader.GetString("firstName"),
                            reader.GetString("lastName"),
                            reader.GetInt32("phoneNumber"),
                            reader.GetInt32("bsn"),
                            reader.GetInt32("wage"),
                            Extentions.ParseEnum<Role>(reader.GetString("role")),
                            reader.GetString("city"),
                            reader.GetString("street"),
                            reader.GetString("zipCode"),
                            reader.GetString("houseNumber"));
                        employees.Add(employee);
                    }
                    return employees;
                }
                catch (InvalidOperationException)
                {
                    return new List<Employee>();
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }
        public List<Employee> GetAllAssignedEmployees(Shift shift)
        {
            using (MySqlConnection Conn = ConnectionString.Connection())
            {
                try
                {
                    Conn.Open();
                    string sql = "select employee.* FROM employee inner join Shift_has_employee on employee.id = employeeid where shiftid = @shiftId";
                    var cmd = new MySqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@shiftId", shift.Id);
                    var reader = cmd.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (reader.Read())
                    {
                       // Extentions.ParseEnum<Role>(reader.GetString(9));
                        //Employee employee = new Employee(
                        //    reader.GetInt32(0),
                        //    reader.GetString(1),
                        //    reader.GetString(2),
                        //    reader.GetInt32(3),
                        //    reader.GetString(4),
                        //    reader.GetString(8),
                        //    reader.GetInt32(5),
                        //    reader.GetString(6),
                        //    reader.GetInt32(7),
                        //    Extentions.ParseEnum<Role>(reader.GetString(9)),
                        //    reader.GetString(10),
                        //    reader.GetString(11),
                        //    reader.GetInt32(12),
                        //    reader.GetString(13));
                        //employees.Add(employee);

                        Employee employee = new Employee(
                             reader.GetInt32("id"),
                            reader.GetString("email"),
                            reader.GetString("password"),
                            reader.GetString("firstName"),
                            reader.GetString("lastName"),
                            reader.GetInt32("phoneNumber"),
                            reader.GetInt32("bsn"),
                            reader.GetInt32("wage"),
                            Extentions.ParseEnum<Role>(reader.GetString("role")),
                            reader.GetString("city"),
                            reader.GetString("street"),
                            reader.GetString("zipCode"),
                            reader.GetString("houseNumber"));
                        employees.Add(employee);
                    }
                    return employees;
                }
                catch (InvalidOperationException)
                {
                    return new List<Employee>();
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }
            }
        }
        public int DoesEmployeehaveMaxHours(DateTime startofweek, int empid)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select count(*) from shift where Date(Date) between @StartOfShift and @EndOfShift and ID in (select ShiftID from `shift_has_employee` where EmployeeID = @EmployeeID)";
                    cmd.Parameters.AddWithValue("@StartOfShift", startofweek);
                    cmd.Parameters.AddWithValue("@EndOfShift", startofweek.AddDays(7));
                    cmd.Parameters.AddWithValue("@employeeID", empid);
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    int rows = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return rows;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public bool CanEmpBeScheduled(DateTime day, int empid)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "Select S.id from Shift as S inner join shift_has_employee as SHE on S.id = SHE.ShiftID where S.Date = @Yesterdate and SHE.EmployeeID = @Employeeid and S.shifttime = 2";
                    cmd.Parameters.AddWithValue("@Date", day);
                    cmd.Parameters.AddWithValue("@Yesterdate", day.AddDays(-1));
                    cmd.Parameters.AddWithValue("@EmployeeID", empid);
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        public bool DeleteEmployeeShift(int id)
        {
            //bool success = false;
            using (MySqlConnection conn = ConnectionString.Connection())
            {
                conn.Open();
                string sqlShift = "DELETE FROM shift_has_employee WHERE EmployeeId = @Id";
                MySqlCommand cmdShift = new MySqlCommand(sqlShift, conn);
                cmdShift.Parameters.AddWithValue("@Id", id);
                cmdShift.ExecuteNonQuery();

                return true;
                try
                {

                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
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
