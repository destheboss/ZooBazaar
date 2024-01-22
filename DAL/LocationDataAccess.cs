using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Interfaces;

namespace DAL
{
	public class LocationDataAccess : ILocationDataAccess
	{
		public void AddChildAnimalLocation(string name, int? parentId)
		{
			MySqlCommand msqlcd;
			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "INSERT INTO location (name, parentId) VALUES (@name, @parentId)";

					msqlcd = new MySqlCommand(query, conn);
					msqlcd.Parameters.AddWithValue("@name", name);
					msqlcd.Parameters.AddWithValue("@parentId", parentId);
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


		public void AddParentAnimalLocation(string name)
		{
			MySqlCommand msqlcd;
			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "INSERT INTO location (name) VALUES (@name)";

					msqlcd = new MySqlCommand(query, conn);
					msqlcd.Parameters.AddWithValue("@name", name);
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

        public bool AreAnimalsInLocationExist(int locationId)
        {
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT COUNT(*) FROM Animal WHERE LocationId = @LocationId";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@LocationId", locationId);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred while checking if animals in location exist: " + ex.Message);
            }
        }
        public bool AreChildLocationsExist(int parentId)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM location WHERE parentId = @parentId";
                    MySqlCommand msqlcd = new MySqlCommand(query, conn);
                    msqlcd.Parameters.AddWithValue("@parentId", parentId);

                    conn.Open();

                    // ExecuteScalar returns the first column of the first row as an object
                    object result = msqlcd.ExecuteScalar();

                    // Convert the result to an integer
                    int count = Convert.ToInt32(result);

                    return count > 0; // If there are child locations, count will be greater than 0
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void DeleteLocation(int id)
		{
			MySqlCommand msqlcd;
			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "DELETE FROM location WHERE id = @id";

					msqlcd = new MySqlCommand(query, conn);
					msqlcd.Parameters.AddWithValue("@id", id);
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

		public List<AnimalLocation> ReadLocations()
		{
			MySqlDataAdapter reader;
			DataTable dt;
			MySqlCommand msqlcd;
			List<AnimalLocation> locations = new List<AnimalLocation>();
			string query = "select * from location";
			AnimalLocation location;
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
						if (row[2] == DBNull.Value)
						{
							locations.Add(location = new AnimalLocation((int)row[0], (string)row[1], null));

						}
						else
						{
							locations.Add(location = new AnimalLocation((int)row[0], (string)row[1], (int?)row[2]));
						}

					}
					return locations;
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

		public DataTable LoadLocations()
		{
			string query = "SELECT * from location";

			using (var conn = ConnectionString.Connection())
			{
				try
				{
					MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
					DataSet ds = new DataSet();
					da.Fill(ds, "dbo.saleInfo");
					return ds.Tables["dbo.saleInfo"];
				}
				catch (Exception)
				{
					throw;
				}
				finally
				{

				}
			}
		}

		public List<AnimalLocation> ReadSubLocations()
		{
			List<AnimalLocation> subLocations = new List<AnimalLocation>();

			try
			{
				using (var conn = ConnectionString.Connection())
				{
					string query = "SELECT * FROM location WHERE parentId IS NOT NULL";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					conn.Open();

					using (MySqlDataReader rdr = cmd.ExecuteReader())
					{
						while (rdr.Read())
						{
							int id = Convert.ToInt32(rdr["id"]);
							string name = rdr["Name"].ToString();
							int? parentId = rdr.IsDBNull(2) ? null : (int?)Convert.ToInt32(rdr["ParentId"]);

							AnimalLocation subLocation = new AnimalLocation(id, name, parentId);
							subLocations.Add(subLocation);
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("An error occurred while retrieving sub locations: " + ex.Message);
			}
			return subLocations;
		}
	}
}
