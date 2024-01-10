using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Interfaces;

namespace DAL
{
    public class TicketDataAccess : ITicketDataAccess
    {
        public void AddTicket(string name, string email, string ticket)
        {
            MySqlCommand msqlcd;

            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    string query = "INSERT INTO ticket (name, email, ticket, used) VALUES (@name, @email, @ticket, @used)";

                    msqlcd = new MySqlCommand(query, conn);
                    msqlcd.Parameters.AddWithValue("@name", name);
                    msqlcd.Parameters.AddWithValue("@email", email);
                    msqlcd.Parameters.AddWithValue("@ticket", ticket);
                    msqlcd.Parameters.AddWithValue("@used", 0);
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
    }
}
