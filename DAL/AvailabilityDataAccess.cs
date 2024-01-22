using BLL.Interfaces;
using BLL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AvailabilityDataAccess : IAvailabilityDataAccess
    {
        public bool AddAvailability(Availability availability)
        {
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    con.Open();
                    string sql = "INSERT INTO availability( Day1, Day2, EmployeeID) VALUES (@Day1, @Day2, @EmployeeID)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Day1", availability.Day1);
                    cmd.Parameters.AddWithValue("@Day2", availability.Day2);
                    cmd.Parameters.AddWithValue("@EmployeeID", availability.EmployeeID);

                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }

        public Availability GetAvailability(int employeeid)
        {
            using (MySqlConnection con = ConnectionString.Connection())
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM availability WHERE EmployeeID = @EmployeeID";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeid);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Availability availability = new Availability(Convert.ToInt32(dr["Day1"]), Convert.ToInt32(dr["Day2"]), employeeid);
                        return availability;
                    }
                    return null;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
        }
    }

}
