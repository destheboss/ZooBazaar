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
    public class ContractDataAccess : IContractDataAccess
    {
        public bool CreateContract(Contract contract)
        {
            using (MySqlConnection conn = ConnectionString.Connection())
                try
                {
                    string sql = "INSERT INTO contract(Id, Name, Length, AmountOfHours) values(@id, @contractname,@length, @amountofhours)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", contract.ContractId);
                    cmd.Parameters.AddWithValue("@contractname", contract.ContractName);
                    cmd.Parameters.AddWithValue("@length", contract.Length);
                    cmd.Parameters.AddWithValue("@amountofhours", contract.AmountOfHours);

                    cmd.ExecuteNonQuery();
                    return true;
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
        public List<Contract> GetAllContracts()
        {
            using (MySqlConnection conn = ConnectionString.Connection())
                try
                {
                    conn.Open();
                    List<Contract> contracts = new List<Contract>();
                    string sql = "SELECT * from contract";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Contract contract = new Contract(Convert.ToInt32(dr["Id"]), Convert.ToString(dr["Name"]),
                        Convert.ToInt32(dr["Length"]), Convert.ToInt32(dr["AmountOfHours"]));
                        contracts.Add(contract);
                    }
                    return contracts;
                }
                finally
                {
                    conn.Close();
                }
        }
        public bool DeleteContract(int id)
        {
            using (MySqlConnection conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM contract WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;

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
        public Contract GetContract(int id)
        {
            using (MySqlConnection conn = ConnectionString.Connection())
                try
                {
                    conn.Open();
                    string sql = "SELECT * from contract WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Contract contract = new Contract(Convert.ToInt32(dr["Id"]), Convert.ToString(dr["Name"]),
                        Convert.ToInt32(dr["Length"]), Convert.ToInt32(dr["AmountOfHours"]));
                        return contract;
                    }
                    return null;
                }
                finally
                {
                    conn.Close();
                }
        }

        public bool UpdateContract(int id, string name, int length, int amountofhourse)
        {
            using (MySqlConnection conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "Update contract set Id=@Id,Name=@Name, Length=@Length,AmountOfHours=@AmountOfHours WHERE Id=@Id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Length", length);
                    cmd.Parameters.AddWithValue("@AmountOfHours", amountofhourse);

                    cmd.ExecuteNonQuery();

                    return true;
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
        public int GetLastAssignedContractId()
        {
            int lastAssignedContractId = 0;

            using (MySqlConnection conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MAX(Id) FROM contract";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        lastAssignedContractId = id;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                }
            }

            return lastAssignedContractId;
        }
    }
}
