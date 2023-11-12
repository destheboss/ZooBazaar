using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AnimalNotes
    {
        public int AnimalNotesId { get; set; }
        public string? EmployeeName { get; set; }
        public int AnimalId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public AnimalNotes(int animalNotesId, string? employeeName, int animalId, string note, DateTime createdAt)
        {
            AnimalNotesId = animalNotesId;
            EmployeeName = employeeName;
            AnimalId = animalId;
            Note = note;
            CreatedAt = createdAt;
        }
    }
}
