using BLL.Interfaces;
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

        public void AddTicket(string name, string email, string ticket)
        {
            _tda.AddTicket(name, email, ticket);
        }
    }
}
