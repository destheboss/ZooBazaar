using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Tickets
    {
        private int id;
        public int Id { get { return id; } set { value = id; } }
        
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string email;
        public string Email { get { return email; } set { email = value; } }

        private string ticket;
        public string Ticket { get { return ticket; } set { ticket = value; } }

		private int month;
		public int Month { get { return month; } set { month = value; } }

		private int type;
		public int Type { get { return type; } set { type = value; } }

		private int used;
        public int Used { get { return used; } set { used = value; } }


        public Tickets() { }

        public Tickets(int id, string name, string email, string ticket, int month, int type, int used)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.ticket = ticket;
            this.used = used;
            this.type = type;
            this.month = month;
        }
    }
}
