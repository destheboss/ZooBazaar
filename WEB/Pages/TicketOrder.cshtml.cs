using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class TicketOrderModel : PageModel
    {
        TicketManager tm = new TicketManager(new TicketDataAccess());
        [BindProperty]
        public Tickets Tickets { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string ticket = GenerateRandomString(5);

            tm.AddTicket(Tickets.Name, Tickets.Email, ticket);

            return RedirectToPage("/Success");
        }

        static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }
    }
}
