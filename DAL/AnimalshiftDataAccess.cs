using BLL.Enums;
using BLL.Models.AutoSchedule;
using BLL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace DAL
{
    public class AnimalshiftDataAccess : IAnimalShiftDataAccess
    {
        //private readonly AnimalDataAccess animalDataAccess = new AnimalDataAccess();
        public bool CreateShift(AnimalShift shift)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO animalshift (animalid, Status, caretype, shifttime) VALUES (@animalid, @shifttype, @caretype, @shifttime);", conn);
                    cmd.Parameters.AddWithValue("@animalid", shift.Animal.Id);
                    cmd.Parameters.AddWithValue("@shifttype", shift.ShiftType);
                    cmd.Parameters.AddWithValue("@caretype", shift.Caretype);
                    cmd.Parameters.AddWithValue("@shifttime", shift.TimeShift);
                    cmd.ExecuteNonQuery();
                    shift.Id = Convert.ToInt32(cmd.LastInsertedId);
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        public List<AnimalShift> GetAnimalShiftsByanimal(Animal animal)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("Select * from animalshift where animalid = @id", conn);
                    cmd.Parameters.AddWithValue("id", animal.Id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<AnimalShift> Shifts = new List<AnimalShift>();
                    while (dr.Read())
                    {
                        AnimalShift shift = new AnimalShift()
                        {
                            Animal = animal,
                            ShiftType = Enum.Parse<ANimalshiftStatus>(dr.GetString("status")),
                            Caretype = Enum.Parse<Animalshiftworktype>(dr.GetString("Caretype")),
                            Id = dr.GetInt32("Id"),
                            TimeShift = dr.GetDateTime("ShiftTime")
                        };
                        Shifts.Add(shift);

                    }
                    return Shifts;
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
        public List<AnimalShift> GetAnimalShifts()
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT Animalshift.* ,a.Id as aid, a.Name as name, a.Weight, a.DateOfBirth, at.Id AS AnimalTypeId, at.Name AS AnimalTypeName, al.Id AS AnimalLocationId, al.Name AS AnimalLocationName FROM AnimalShift inner JOIN Animal as a ON a.id = Animalshift.animalid LEFT JOIN Animaltype as at ON a.AnimalTypeId = at.Id LEFT JOIN Location as al ON a.LocationId = al.Id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<AnimalShift> Shifts = new List<AnimalShift>();
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["aid"]);
                        string animalName = dr["name"].ToString();
                        int locationId = Convert.ToInt32(dr["AnimalLocationId"]);
                        int animalTypeId = Convert.ToInt32(dr["AnimalTypeId"]);
                        var weight = Convert.ToDecimal(dr["Weight"]);
                        DateTime birthday = (DateTime)dr["DateOfBirth"];
                        string animalTypeName = dr["AnimalTypeName"].ToString();
                        string animalLocationName = dr["AnimalLocationName"].ToString();
                        //AnimalStatus animalStatus = (AnimalStatus)System.Enum.Parse(typeof(AnimalStatus), dr["aStatus"].ToString());

                        AnimalType animalType = new AnimalType(animalTypeId, animalTypeName, null);
                        AnimalLocation animalLocation = new AnimalLocation(locationId, animalLocationName, null);
                        Animal animal = new Animal(id, animalName, birthday, weight, animalType, animalLocation/*, animalStatus*/);
                        AnimalShift shift = new AnimalShift()
                        {

                            Animal = animal,
                            ShiftType = Enum.Parse<ANimalshiftStatus>(dr.GetString("status")),
                            Caretype = Enum.Parse<Animalshiftworktype>(dr.GetString("Caretype")),
                            Id = dr.GetInt32("Id"),
                            TimeShift = dr.GetDateTime("ShiftTime")
                        };
                        Shifts.Add(shift);

                    }
                    return Shifts;
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
        public bool Deleteshift(AnimalShift shift)
        {
            using (var conn = ConnectionString.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from animalshift where id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", shift.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    return false;
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
