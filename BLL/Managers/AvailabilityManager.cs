using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class AvailabilityManager
    {
        private readonly IAvailabilityDataAccess Data;

        public AvailabilityManager(IAvailabilityDataAccess Data)
        {
            this.Data = Data;
        }
        public bool AddAvailability(Availability availability)
        {
            return Data.AddAvailability(availability);
        }

        public Availability GetAvailability(int employeeid)
        {
            return Data.GetAvailability(employeeid);
        }
    }

}
