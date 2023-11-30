using BLL.Enums;
using BLL.Models.AutoSchedule;
using BLL.Models;
using ClassLibrary.Extentions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace DAL
{
    public class ShiftDataAccess : IShiftDataAccess
    {
        public bool CreateShift(Shift shift, out int id)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Shift ( Date , shifttime) VALUES ( @Date , @shifttime)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Date", shift.Date);
                    cmd.Parameters.AddWithValue("@shifttime", shift.Shifttime);
                    bool succes = cmd.ExecuteNonQuery() > 0;
                    id = Convert.ToInt32(cmd.LastInsertedId);
                    return succes;
                }
                catch (Exception ex)
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
        public Shift? GetShift(DateTime date, Shifttime shifttime)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "Select * from Shift where Date = @Date and shifttime = @shifttime";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@shifttime", shifttime);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Shift shift = new Shift();
                        shift.Id = Convert.ToInt32(dr["Id"]);
                        shift.Date = dr.GetDateTime("Date");
                        shift.Shifttime = Extentions.ParseEnum<Shifttime>(dr["shifttime"].ToString());
                        return shift;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        public List<Shift> GetAllShifts()
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shift", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Shift> shifts = new List<Shift>();
                    while (reader.Read())
                    {
                        Shift shift = new Shift();
                        shift.Id = reader.GetInt32("Id");
                        shift.Date = reader.GetDateTime("Date");
                        Enum.TryParse<Shifttime>(reader.GetString("Shifttime"), true, out Shifttime result);
                        shift.Shifttime = result;
                        shifts.Add(shift);
                    }
                    return shifts;
                }
                catch (Exception ex)
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
        public List<Shift> GetShiftsBetweenDates(DateTime Start, DateTime end)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shift where Date Between @start and @end", conn);
                    cmd.Parameters.AddWithValue("@start", Start);
                    cmd.Parameters.AddWithValue("@end", end);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Shift> shifts = new List<Shift>();
                    while (reader.Read())
                    {
                        Shift shift = new Shift();
                        shift.Id = reader.GetInt32("Id");
                        shift.Date = reader.GetDateTime("Date");
                        Enum.TryParse<Shifttime>(reader.GetString("Shifttime"), true, out Shifttime result);
                        shift.Shifttime = result;
                        shifts.Add(shift);
                    }
                    return shifts;
                }
                catch (Exception ex)
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
        public List<Shift> GetAllShiftsByemp(int Empid)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shift inner join shift_has_employee on shift.id = Shiftid where employeeid = @id ", conn);
                    cmd.Parameters.AddWithValue("@id", Empid);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Shift> shifts = new List<Shift>();
                    while (reader.Read())
                    {
                        Shift shift = new Shift();
                        shift.Id = reader.GetInt32("Id");
                        shift.Date = reader.GetDateTime("Date");
                        Enum.TryParse<Shifttime>(reader.GetString("Shifttime"), true, out Shifttime result);
                        shift.Shifttime = result;
                        shifts.Add(shift);
                    }
                    return shifts;
                }
                catch (Exception ex)
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
        public bool DeleteShift(int id)
        {
            throw new NotImplementedException();
        }

        public bool Assignemployee(Shift shift, Employee employee)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Shift_has_employee (ShiftId, EmployeeId) VALUES (@ShiftId, @EmployeeId)", conn);
                    cmd.Parameters.AddWithValue("@ShiftId", shift.Id);
                    cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
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

        public bool UnAssignEmployee(Shift shift, Employee employee)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete From Shift_has_employee Where shiftid = @shiftid and Employeeid = @employeeid", conn);
                    cmd.Parameters.AddWithValue("@ShiftId", shift.Id);
                    cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
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

        public int GetAmountassigned(Shift shift)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Shift_has_employee WHERE ShiftId = @ShiftId", conn);
                    cmd.Parameters.AddWithValue("@ShiftId", shift.Id);

                    return Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
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
    }
}
