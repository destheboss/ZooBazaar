using BLL.Models;
using BLL.Managers;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class ProfileUpdateModel : PageModel
    {
        public UserManager userManager = new UserManager(new UserDataAccess());

        [BindProperty]
        public Employee Person { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(User.FindFirst("EmpID").Value);
            Person = userManager.GetEmployeeById(id);
        }

        public IActionResult OnPostUpdate()
        {
			int id = Convert.ToInt32(User.FindFirst("EmpID").Value);

			userManager.EmployeeSelfUpdate(id, Person.Email, Person.PhoneNumber, Person.City, Person.Street, Person.ZipCode, Person.HouseNumber);

            return RedirectToPage("/Profile");	
		}

    }
}

