using BLL.Models;
using BLL.Managers;
using DAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class ProfileModel : PageModel
    {
        public UserManager userManager = new UserManager(new UserDataAccess());
        public Employee Emp { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(User.FindFirst("EmpID").Value);
            Emp = userManager.GetEmployeeById(id);
        }

        public IActionResult OnPost()
        {
            HttpContext.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
