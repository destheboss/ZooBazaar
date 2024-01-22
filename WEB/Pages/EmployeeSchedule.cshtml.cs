using BLL.Enums;
using BLL.Managers;
using BLL.Models.AutoSchedule;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    [Authorize]
    public class EmployeeScheduleModel : PageModel
    {
		public DateTime monday { get; set; }
		public DateTime sunday { get; set; }
		private ShiftManager shiftManager;
		public List<bool> Hasshift = new List<bool>();

        public EmployeeScheduleModel()
        {
            shiftManager = new ShiftManager(new ShiftDataAccess());
        }
        public void OnGet()
		{
			if (Request.Cookies.ContainsKey("skipweek"))
			{
				int skipday = Convert.ToInt32(Request.Cookies["Skipweek"]);
				DateTime Intermediatedate = DateTime.Now.AddDays(skipday * 7);
				monday = Intermediatedate.AddDays(-(int)Intermediatedate.DayOfWeek + (int)DayOfWeek.Monday);
				sunday = monday.AddDays(6);
			}
			else
			{
				monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
				sunday = monday.AddDays(6);
			}
			List<Shift> filteredshifts = shiftManager.GetAllShiftByEmp(Convert.ToInt32(User.FindFirst("EmpID").Value)).Where(X => X.Date.Date >= monday.Date && X.Date.Date <= monday.AddDays(7).Date).ToList();
			List<bool> hasShiftNow = new List<bool>();

			int b = 0;
			DateTime thisdate = monday.AddDays(-1);

			for (int i = 0; i < 21; i++)
			{
				thisdate = thisdate.AddDays(1);
				if (i % 7 == 0 && i != 0)
				{
					b++;
					thisdate = thisdate.AddDays(-7);
				}

				if (filteredshifts.FirstOrDefault(x => x.Date.Date == thisdate.Date && x.Shifttime == (Shifttime)b) != null)
				{
					hasShiftNow.Add(true);
				}
				else
				{
					hasShiftNow.Add(false);
				}
			}
			Hasshift = hasShiftNow;
		}
        public IActionResult OnPostNextWeek()
        {
            int skipWeek = Request.Cookies.ContainsKey("skipweek") ? Convert.ToInt32(Request.Cookies["skipweek"]) : 0;

            skipWeek++;

            Response.Cookies.Append("skipweek", skipWeek.ToString());

            return RedirectToPage();
        }
        public IActionResult OnPostPreviousWeek()
        {
            int skipWeek = Request.Cookies.ContainsKey("skipweek") ? Convert.ToInt32(Request.Cookies["skipweek"]) : 0;

            skipWeek--;

            Response.Cookies.Append("skipweek", skipWeek.ToString());

            return RedirectToPage();
        }

    }
}
