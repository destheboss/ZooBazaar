using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AnimalNotes
    {
        public int NoteId { get; set; }
        public int EmployeeId { get; set; }
        public int AnimalId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }

        public AnimalNotes()
        {

        }
        public AnimalNotes(int noteId, int employeeId, int animalId, string note, DateTime createdAt)
        {
            NoteId = noteId;
            EmployeeId = employeeId;
            AnimalId = animalId;
            Note = note;
            CreatedAt = createdAt;
        }
    }
}
