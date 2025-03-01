using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageExample.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "user" && Password == "password")
            {
                HttpContext.Session.SetString("User", Username);
                return RedirectToPage("/Index"); // Redirect to home after login
            }

            ErrorMessage = "Invalid username or password!";
            return Page();
        }
    }
}
