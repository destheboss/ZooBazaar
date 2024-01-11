using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace WEB.Pages
{
    public class AvailabilityModel : PageModel
    {
        AvailabilityManager AvailabilityManager = new AvailabilityManager(new AvailabilityDataAccess());
        public Availability Availability { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(User.FindFirst("EmpID").Value);
            Availability = AvailabilityManager.GetAvailability(id);
        }
        public void OnPost(int selectedDay1, int selectedDay2)
        {
            int id = Convert.ToInt32(User.FindFirst("EmpID").Value);
            Availability availability = new Availability(selectedDay1, selectedDay2, id);
            AvailabilityManager.AddAvailability(availability);
        }
    }
}
