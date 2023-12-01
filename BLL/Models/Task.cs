using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }   
        public int EmployeeId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateOnly DueDate { get; set;}
        public Task(int id, string taskDescription, int employeeId, bool isCompleted, DateTime createdAt, DateOnly dueDate)
        {
            Id = id;
            TaskDescription = taskDescription;
            EmployeeId = employeeId;
            IsCompleted = isCompleted;
            CreatedAt = createdAt;
            DueDate = dueDate;
        }
    }
}
