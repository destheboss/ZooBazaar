using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net;
using System.Globalization;

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
            string ticket = GenerateRandomString(10);

			DateTime currentDate = DateTime.Now;
			int monthNumber = currentDate.Month;

			tm.AddTicket(Tickets.Name, Tickets.Email, ticket, Tickets.Type, monthNumber);

            string emailSubject = "Order Confirmation";

            string emailBody = $@"
                        <div style='font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px; border-radius: 10px;'>
                            <div style='text-align: right;'>
                                <img src='' alt='Company Logo' style='max-width: 100px; width: 100%; height: auto;' />
                            </div>
                            <h2 style='color: #333; text-align: center; margin-bottom: 20px;'>Email Confirmation for Your Order</h2>
                            <p style='color: #333;'>
                                Thank you for purchasing from the ZooManiacite! 
                                Your Ticket Number: {ticket}
                            </p>
                            <p style='color: #333;'>

                                <strong>Name:</strong> {Tickets.Name}
                            </p>
                            <p style='color: #333; margin-top: 20px;'>
                                We look forward to seeing you again!.
                            </p>
                            <p style='color: #008000; font-weight: bold; margin-top: 20px;'>
                                Best Regards,
                                <br/>
                                FRIDGEMATE
                            </p>
                        </div>";

            SendEmail(Tickets.Email, emailSubject, emailBody);

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
        private void SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("ldelzell17@gmail.com", "lguo rgyq iqha mppx");
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("your-email@example.com");
                        mailMessage.To.Add(recipientEmail);
                        mailMessage.Subject = subject;

                        // Use HTML formatting for the email body
                        mailMessage.Body = $"<html><body>{body}</body></html>";
                        mailMessage.IsBodyHtml = true;

                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("SmtpException: " + ex.Message);
                throw;
            }
        }
	}
}
