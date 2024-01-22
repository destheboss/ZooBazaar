using BLL.Models;
using MySql.Data.MySqlClient;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Managers;

namespace DAL
{
    public class AnimalDataAccess: IAnimalDataAccess
    {
        public List<Animal> GetAllAnimals()
        {
            List<Animal> animalList = new List<Animal>();
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT a.Id, a.Name, a.Weight, a.DateOfBirth, at.Id AS AnimalTypeId, at.Name AS AnimalTypeName, al.Id AS AnimalLocationId, al.Name AS AnimalLocationName " +
                        "FROM Animal as a " +
                        "LEFT JOIN Animaltype as at ON a.AnimalTypeId = at.Id " +
                        "LEFT JOIN Location as al ON a.LocationId = al.Id";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = Convert.ToInt32(rdr["Id"]);
                            string animalName = rdr["Name"].ToString();

                            // Check if AnimalLocationId is DBNull.Value (even though it's not nullable)
                            int locationId = Convert.ToInt32(rdr["AnimalLocationId"]);

                            // Check if AnimalTypeId is DBNull.Value (even though it's not nullable)
                            int animalTypeId = Convert.ToInt32(rdr["AnimalTypeId"]);

                            var weight = Convert.ToDecimal(rdr["Weight"]);
                            DateTime birthday = (DateTime)rdr["DateOfBirth"];
                            string animalTypeName = rdr["AnimalTypeName"].ToString();
                            string animalLocationName = rdr["AnimalLocationName"].ToString();

                            AnimalType animalType = new AnimalType(animalTypeId, animalTypeName, null);
                            AnimalLocation animalLocation = new AnimalLocation(locationId, animalLocationName, null);
                            Animal animal = new Animal(id, animalName, birthday, weight, animalType, animalLocation);

                            animalList.Add(animal);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving animals: " + ex.Message);
            }
            return animalList;
        }

        public List<Animal> GetAllAliveAnimals()
        {
            List<Animal> animalAliveList = new List<Animal>();
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT a.Id, a.Name, a.Weight, a.DateOfBirth, /*a.Status,*/ at.Id AS AnimalTypeId, at.Name AS AnimalTypeName, al.Id AS AnimalLocationId, al.Name AS AnimalLocationName FROM Animal as a LEFT JOIN Animaltype as at ON a.AnimalTypeId = at.Id LEFT JOIN Location as al ON a.LocationId = al.Id /*WHERE a.Status = 'Alive'*/ ";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = Convert.ToInt32(rdr["Id"]);
                            string animalName = rdr["Name"].ToString();
                            int locationId = Convert.ToInt32(rdr["AnimalLocationId"]);
                            int animalTypeId = Convert.ToInt32(rdr["AnimalTypeId"]);
                            var weight = Convert.ToDecimal(rdr["Weight"]);
                            DateTime birthday = (DateTime)rdr["DateOfBirth"];
                            string animalTypeName = rdr["AnimalTypeName"].ToString();
                            string animalLocationName = rdr["AnimalLocationName"].ToString();
                            //AnimalStatus animalStatus = (AnimalStatus)System.Enum.Parse(typeof(AnimalStatus), rdr["Status"].ToString());

                            AnimalType animalType = new AnimalType(animalTypeId, animalTypeName, null);
                            AnimalLocation animalLocation = new AnimalLocation(locationId, animalLocationName, null);
                            Animal animal = new Animal(id, animalName, birthday, weight, animalType, animalLocation/*, animalStatus*/);

                            animalAliveList.Add(animal);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving animals: " + ex.Message);
            }
            return animalAliveList;
        }

        public Animal GetAnimalById(int ids)
        {
            List<Animal> animalList = new List<Animal>();
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT a.Id, a.Name, a.Weight, a.DateOfBirth, at.Id AS AnimalTypeId, at.Name AS AnimalTypeName, al.Id AS AnimalLocationId, al.Name AS AnimalLocationName " +
                        "FROM Animal as a " +
                        "LEFT JOIN Animaltype as at ON a.AnimalTypeId = at.Id " +
                        "LEFT JOIN Location as al ON a.LocationId = al.Id where a.id = @id";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@id", ids);

                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            int id = Convert.ToInt32(rdr["Id"]);
                            string animalName = rdr["Name"].ToString();
                            int locationId = Convert.ToInt32(rdr["AnimalLocationId"]);
                            int animalTypeId = Convert.ToInt32(rdr["AnimalTypeId"]);
                            var weight = Convert.ToDecimal(rdr["Weight"]);
                            DateTime birthday = (DateTime)rdr["DateOfBirth"];
                            string animalTypeName = rdr["AnimalTypeName"].ToString();
                            string animalLocationName = rdr["AnimalLocationName"].ToString();
                            //AnimalStatus animalStatus = (AnimalStatus)System.Enum.Parse(typeof(AnimalStatus), rdr["Status"].ToString());

                            AnimalType animalType = new AnimalType(animalTypeId, animalTypeName, null);
                            AnimalLocation animalLocation = new AnimalLocation(locationId, animalLocationName, null);
                            Animal animal = new Animal(id, animalName, birthday, weight, animalType, animalLocation /*animalStatus*/);

                            return animal;
                        }
                    }
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving animals: " + ex.Message);
                return null;
            }
        }

        public List<Animal> SearchAnimalsByName(string searchTerm)
        {
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT a.Id, a.Name, a.Weight, a.DateOfBirth, at.Id AS AnimalTypeId, at.Name AS AnimalTypeName, al.Id AS AnimalLocationId, al.Name AS AnimalLocationName " +
                        "FROM Animal as a " +
                        "LEFT JOIN Animaltype as at ON a.AnimalTypeId = at.Id " +
                        "LEFT JOIN Location as al ON a.LocationId = al.Id WHERE a.Name = @name";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@name", searchTerm);

                    con.Open();
                    List<Animal> searchResults = new List<Animal>();

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int animalId = Convert.ToInt32(rdr["Id"]);
                            int locationId = Convert.ToInt32(rdr["AnimalLocationId"]);
                            int animalTypeId = Convert.ToInt32(rdr["AnimalTypeId"]);
                            var weight = Convert.ToDecimal(rdr["Weight"]);
                            DateTime birthday = (DateTime)rdr["DateOfBirth"];
                            string animalTypeName = rdr["AnimalTypeName"].ToString();
                            string animalLocationName = rdr["AnimalLocationName"].ToString();

                            AnimalType animalType = new AnimalType(animalTypeId, animalTypeName, null);
                            AnimalLocation animalLocation = new AnimalLocation(locationId, animalLocationName, null);
                            Animal animal = new Animal(animalId, searchTerm, birthday, weight, animalType, animalLocation);

                            searchResults.Add(animal);
                        }
                    }

                    return searchResults;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving animals: " + ex.Message);
                return null;
            }
        }

        public bool AddAnimal(Animal animal)
        {
            bool success = false;
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "INSERT INTO Animal (Name, DateOfBirth, Weight, AnimalTypeId, LocationId /*Status*/) VALUES (@Name, @DateOfBirth, @Weight, @AnimalTypeId, @LocationId/*, @AnimalStatus*/)";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@Name", animal.AnimalName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", animal.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Weight", animal.AnimalWeight);
                    cmd.Parameters.AddWithValue("@AnimalTypeId", animal.AnimalType.GetID());
                    cmd.Parameters.AddWithValue("@LocationId", animal.AnimalLocation.GetID());
                    //cmd.Parameters.AddWithValue("@AnimalStatus", animal.AnimalStatus.ToString());

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = (rowsAffected == 1);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred while adding animal: " + ex.Message);
            }

            return success;
        }

        public bool RemoveAnimal(int id)
        {
            bool success = false;
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "DELETE FROM Animal WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = (rowsAffected == 1);

                    if (success)
                    {
                        Animal animal = new Animal(id);

                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while removing animal: " + ex.Message);
            }

            return success;
        }
        public List<BLL.Models.Task> GetIncompleteTasks(int employeeId)
        {
            List<BLL.Models.Task> incompleteTasks = new List<BLL.Models.Task>();
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT Id, TaskDescription, EmployeeId, IsCompleted, CreatedAt, DueDate FROM Tasks WHERE EmployeeId = @EmployeeId AND IsCompleted = 0";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = Convert.ToInt32(rdr["Id"]);
                            string taskDescription = rdr["TaskDescription"].ToString();
                            int taskId = Convert.ToInt32(rdr["EmployeeId"]);
                            bool isCompleted = Convert.ToBoolean(rdr["IsCompleted"]);
                            DateTime createdAt = Convert.ToDateTime(rdr["CreatedAt"]);
                            DateOnly dueDate = (DateOnly)rdr["DueDate"];

                            BLL.Models.Task task = new BLL.Models.Task(id, taskDescription, taskId, isCompleted, createdAt, dueDate);
                            incompleteTasks.Add(task);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving tasks: " + ex.Message);
            }
            return incompleteTasks;
        }

        public bool AddNote(AnimalNotes newnote)
        {
            bool success = false;
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "INSERT INTO animalnotes (AnimalId, EmployeeId, Note, CreatedAt, NoteId) VALUES (@AnimalId, @EmployeeId, @Note, @CreatedAt, @NoteId)";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@AnimalId", newnote.AnimalId);
                    cmd.Parameters.AddWithValue("@EmployeeId", newnote.EmployeeId);
                    cmd.Parameters.AddWithValue("@Note", newnote.Note);
                    cmd.Parameters.AddWithValue("@CreatedAt", newnote.CreatedAt);
                    cmd.Parameters.AddWithValue("@NoteId", newnote.NoteId);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = (rowsAffected == 1);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while adding task: " + ex.Message);
            }

            return success;
        }
        public List<AnimalNotes> GetNotesByAnimalId(int animalId)
        {
            List<AnimalNotes> noteList = new List<AnimalNotes>();

                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "SELECT * FROM AnimalNotes WHERE AnimalId = @AnimalId";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@AnimalId", animalId);

                    con.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int animalNotesId = Convert.ToInt32(rdr["NoteId"]);
                            int caretakerId = Convert.ToInt32(rdr["EmployeeId"]);
                            int noteAnimalId = Convert.ToInt32(rdr["AnimalId"]);
                            string note = rdr["Note"].ToString();
                            DateTime createdAt = Convert.ToDateTime(rdr["CreatedAt"]);

                            AnimalNotes animalNote = new AnimalNotes(animalNotesId, caretakerId, noteAnimalId, note, createdAt);
                            noteList.Add(animalNote);
                        }
                    }
                }
            try
            {
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while retrieving notes: " + ex.Message);
            }

            return noteList;
        }
        public bool UpdateAnimal(Animal animal)
        {
            bool success = false;
            try
            {
                using (MySqlConnection con = ConnectionString.Connection())
                {
                    string sqlQuery = "UPDATE Animal SET Name = @Name, DateOfBirth = @DateOfBirth, Weight = @Weight, animalTypeId = @TypeId, LocationId = @LocationId WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@Id", animal.Id);
                    cmd.Parameters.AddWithValue("@Name", animal.AnimalName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", animal.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Weight", animal.AnimalWeight);
                    cmd.Parameters.AddWithValue("@TypeId", animal.AnimalType.GetID());
                    cmd.Parameters.AddWithValue("@LocationId", animal.AnimalLocation.GetID());
                    //cmd.Parameters.AddWithValue("@AnimalStatus", animal.AnimalStatus.ToString());

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = (rowsAffected == 1);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while updating animal: " + ex.Message);
            }

            return success;
        }
    }
}
