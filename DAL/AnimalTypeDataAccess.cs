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
	public class AnimalTypeDataAccess : IAnimalTypeDataAccess
	{
		public void AddChildAnimalType(string name, int? parentId)
		{
			MySqlCommand msqlcd;

			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "INSERT INTO animaltype (name, parentId) VALUES (@name, @parentId)";

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

		public void AddParentAnimalType(string name)
		{
			MySqlCommand msqlcd;

			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "INSERT INTO animaltype (name) VALUES (@name)";

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

		public void DeleteType(int id)
		{
			MySqlCommand msqlcd;

			using (var conn = ConnectionString.Connection())
			{
				try
				{
					string query = "DELETE FROM animaltype WHERE id = @id";

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

		public List<AnimalType> ReadAnimalTypes()
		{
			MySqlDataAdapter reader;
			DataTable dt;
			MySqlCommand msqlcd;
			List<AnimalType> types = new List<AnimalType>();
			string query = "select * from animaltype";
			AnimalType type;
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
							types.Add(type = new AnimalType((int)row[0], (string)row[1], null));

						}
						else
						{
							types.Add(type = new AnimalType((int)row[0], (string)row[1], (int?)row[2]));
						}

					}
					return types;
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

		public DataTable LoadTypes()
		{
			string query = "SELECT * from animaltype";

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

		public List<AnimalType> ReadSubAnimalTypes()
		{
			List<AnimalType> subTypes = new List<AnimalType>();
			try
			{
				using (MySqlConnection con = ConnectionString.Connection())
				{
					string sqlQuery = "SELECT Id, Name, ParentId FROM AnimalType WHERE ParentId IS NOT NULL";
					MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

					con.Open();
					using (MySqlDataReader rdr = cmd.ExecuteReader())
					{
						while (rdr.Read())
						{
							int id = Convert.ToInt32(rdr["Id"]);
							string name = rdr["Name"].ToString();
							int? parentId = Convert.ToInt32(rdr["ParentId"]);
							AnimalType subType = new AnimalType(id, name, parentId);
							subTypes.Add(subType);
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("An error occurred while retrieving sub animal types: " + ex.Message);
			}
			return subTypes;
		}
	}
}
