using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class AnimalTask
    {
        public int TaskId { get; set; }
        public int CaretakerId { get; set; }
        public int AnimalId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        // Add other properties as needed

        // You may also want to add navigation properties to relate the task to a caretaker or an animal
        public virtual Employee Employee { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
