using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Trail2.Models; // Ensure this namespace is included
using Trail2.Helpers; // Include the password helper
using System.Linq; // Make sure to include System.Linq for FirstOrDefault

namespace Trail2.Pages
{
    public class Index : PageModel
    {
        private readonly DatabaseContext _context;

        public Index(DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public IActionResult OnPost()
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(Input.Username) || string.IsNullOrWhiteSpace(Input.Password))
            {
                ModelState.AddModelError(string.Empty, "Username and password cannot be empty.");
                return Page();
            }

            // Hash the entered password
            var hashedPassword = PasswordHelper.HashPassword(Input.Password);

            // Check if the user exists with the provided username and hashed password
            var user = _context.Users
                .FirstOrDefault(u => u.Username == Input.Username && u.PasswordHash == hashedPassword);

            if (user != null)
            {
                // Set the session variable for the logged-in user
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                TempData["SuccessMessage"] = "Login successful!";
                return RedirectToPage("/Dashboard");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt."); // Invalid credentials
                return Page();
            }
        }

    }
}
