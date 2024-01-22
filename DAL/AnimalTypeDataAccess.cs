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
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    // Check if parentId exists in location table
                    if (parentId.HasValue)
                    {
                        string checkParentQuery = "SELECT COUNT(*) FROM location WHERE id = @parentId";
                        using (var checkParentCmd = new MySqlCommand(checkParentQuery, conn))
                        {
                            checkParentCmd.Parameters.AddWithValue("@parentId", parentId.Value);

                            conn.Open();
                            int count = Convert.ToInt32(checkParentCmd.ExecuteScalar());
                            conn.Close();

                            if (count == 0)
                            {
                                // ParentId does not exist in location table, handle accordingly
                                // Throw an exception or log an error
                                throw new Exception("ParentId does not exist in the location table.");
                            }
                        }
                    }

                    // Insert into animaltype table
                    string insertQuery = "INSERT INTO animaltype (name, parentId) VALUES (@name, @parentId)";
                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@parentId", parentId);

                        conn.Open();
                        insertCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    // Handle exception appropriately
                    throw;
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
        public bool AreAnimalsOfTypeExist(int typeId)
        {
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT COUNT(*) FROM Animal WHERE AnimalTypeId = @TypeId";
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@TypeId", typeId);

                        con.Open();
                        if (int.TryParse(cmd.ExecuteScalar()?.ToString(), out int count))
                        {
                            return count > 0;
                        }
                        else
                        {
                            // Handle the case where the count is not a valid integer
                            throw new Exception("Error converting count to integer.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred while checking if animals of type exist: " + ex.Message);
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
