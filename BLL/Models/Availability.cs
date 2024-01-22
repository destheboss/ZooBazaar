using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Availability
    {
        public int Day1 { get; set; }
        public int Day2 { get; set; }

        public int EmployeeID { get; set; }

        public Availability() { }

        public Availability(int day1, int day2, int employeeid)
        {
            Day1 = day1;
            Day2 = day2;
            EmployeeID = employeeid;
        }
    }

}
