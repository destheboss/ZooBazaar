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
        public int CaretakerId { get; set; }
        public int AnimalId { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
