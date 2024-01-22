using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Interfaces;
using System.Data;

namespace DAL
{
    public class TicketDataAccess : ITicketDataAccess
    {
        public void AddTicket(string name, string email, string ticket, int type, int month)
        {
            MySqlCommand msqlcd;

            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    string query = "INSERT INTO ticket (name, email, ticket, type, month, used) VALUES (@name, @email, @ticket, @type, @month, @used)";

                    msqlcd = new MySqlCommand(query, conn);
                    msqlcd.Parameters.AddWithValue("@name", name);
                    msqlcd.Parameters.AddWithValue("@email", email);
                    msqlcd.Parameters.AddWithValue("@ticket", ticket);
					msqlcd.Parameters.AddWithValue("@type", type);
					msqlcd.Parameters.AddWithValue("@month", month);
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

		public List<Tickets> GetAllTickets()
		{
			MySqlDataAdapter reader;
			DataTable dt;
			MySqlCommand cd;
			List<Tickets> tcks = new List<Tickets>();
			string query = "SELECT * FROM ticket";
			Tickets t;
			using (var conn = ConnectionString.Connection())
			{
				try
				{
					reader = new MySqlDataAdapter();
					dt = new DataTable();
					cd = new MySqlCommand(query, conn);
					conn.Open();
					reader.SelectCommand = cd;
					reader.Fill(dt);
					foreach (DataRow row in dt.Rows)
					{
						tcks.Add(t = new Tickets((int)row[0], (string)row[1], (string)row[2], (string)row[3], (int)row[4], (int)row[5], (int)row[6]));
					}
					return tcks;
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
