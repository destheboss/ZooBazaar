using DAL;
using BLL.Managers;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using BCryptNet = BCrypt.Net.BCrypt;

namespace WEB.Pages
{
    public class loginModel : PageModel
    {
        public CredentialsManager cm = new CredentialsManager(new CredentialsDataAccess());
        public List<Credentials> creds { get; set; }

        [BindProperty]
        public Credentials cred { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            creds = cm.ReadCredentials();

            foreach (var item in creds) 
            {
                bool isMatch = BCryptNet.Verify(cred.HashPass, item.HashPass);
                if (isMatch == true && item.EmpID == cred.EmpID)
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim("empID", item.EmpID.ToString()));


                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/Index");
                }
            }

            return RedirectToPage("/Login");
        }
    }
}
