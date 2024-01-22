using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface ITicketDataAccess
    {
        public void AddTicket(string name, string email, string ticket, int type, int month);
        public List<Tickets> GetAllTickets();
    }
}
