using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class TicketStatsModel : PageModel
    {
        TicketManager tm = new TicketManager(new TicketDataAccess());

        public int NormalTickets { get; set; }
        public int KidsTickets { get; set; }
        public int GroupTickets { get; set; }
        public int January { get; set; }
        public int February { get; set; }
        public int March { get; set; }
		public int April { get; set; }
		public int May { get; set; }
		public int June { get; set; }
		public int July { get; set; }
		public int August { get; set; }
		public int September { get; set; }
		public int October { get; set; }
		public int November { get; set; }
		public int December { get; set; }


		public void OnGet()
        {
            NormalTickets = 0;
            KidsTickets = 0;
            GroupTickets = 0;
            January = 0;
            February = 0;
            March = 0;
            April = 0;
            May = 0;
            June = 0;
            July = 0;
            August = 0;
            September = 0;
            October = 0;
            November = 0;
            December = 0;



			List<Tickets> tickets = tm.GetAllTickets();

            foreach(Tickets t in tickets)
            {
                if(t.Type == 1)
                {
                    NormalTickets++;
                }
                else if (t.Type == 2)
                {
                    KidsTickets++;
                }
                else if (t.Type == 3)
                {
                    GroupTickets++;
                }
            }

			foreach (Tickets t in tickets)
			{
				if (t.Month  == 1)
				{
					January++;
				}
				else if (t.Month == 2)
				{
					February++;
				}
				else if (t.Month == 3)
				{
					March++;
				}
				else if (t.Month == 4)
				{
					April++;
				}
				else if (t.Month == 5)
				{
					May++;
				}
				else if (t.Month == 6)
				{
					June++;
				}
				else if (t.Month == 7)
				{
					July++;
				}
				else if (t.Month == 8)
				{
					August++;
				}
				else if (t.Month == 9)
				{
					September++;
				}
				else if (t.Month == 10)
				{
					October++;
				}
				else if (t.Month == 11)
				{
					November++;
				}
				else if (t.Month == 12)
				{
					December++;
				}
			}

		}
	}
}
