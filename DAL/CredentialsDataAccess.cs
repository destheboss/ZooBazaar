using BLL.Interfaces;
using BLL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
	public class CredentialsDataAccess : ICredentialsDataAccess
	{
		public void AddProfile(int empID, string pass, string salt)
		{
			MySqlCommand msqlcd;
			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "INSERT INTO credentials (empID, pass, salt) VALUES (@empID, @pass, @salt)";

					msqlcd = new MySqlCommand(query, conn);
					msqlcd.Parameters.AddWithValue("@empID", empID);
					msqlcd.Parameters.AddWithValue("@pass", pass);
					msqlcd.Parameters.AddWithValue("@salt", salt);
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

        public List<Credentials> ReadCredentials()
        {
            MySqlDataAdapter reader;
            DataTable dt;
            MySqlCommand msqlcd;
            List<Credentials> creds = new List<Credentials>();
            string query = "select * from credentials";
            Credentials cred;
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    reader = new MySqlDataAdapter();
                    dt = new DataTable();
                    msqlcd = new MySqlCommand(query, conn);
                    conn.Open();
                    reader.SelectCommand = msqlcd;
                    reader.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        creds.Add(cred = new Credentials((int)row[0], (string)row[1], (string)row[2]));
                    }
                    return creds;
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
