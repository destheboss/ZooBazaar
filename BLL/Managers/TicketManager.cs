using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class TicketManager
    {
        private readonly ITicketDataAccess _tda;

        public TicketManager(ITicketDataAccess tda)
        {
            _tda = tda;
        }

        public void AddTicket(string name, string email, string ticket, int type, int month)
        {
            _tda.AddTicket(name, email, ticket, type, month);
        }

        public List<Tickets> GetAllTickets()
        {
            return _tda.GetAllTickets();
        }
    }
}
