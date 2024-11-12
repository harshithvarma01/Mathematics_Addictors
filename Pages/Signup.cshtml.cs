using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using Trail2.Models; // Ensure this namespace is included
using Trail2.Helpers; // Include the password helper

namespace Trail2.Pages
{
    public class SignupModel : PageModel
    {
        private readonly DatabaseContext _context;

        public SignupModel(DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Username { get; set; }
            public string Email { get; set; } // Added Email property
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return if the model state is invalid
            }

            if (Input.Password == Input.ConfirmPassword)
            {
                // Check if the username already exists
                if (_context.Users.Any(u => u.Username == Input.Username))
                {
                    ModelState.AddModelError(string.Empty, "Username already exists.");
                    return Page();
                }

                // Check if the email already exists
                if (_context.Users.Any(u => u.Email == Input.Email))
                {
                    ModelState.AddModelError(string.Empty, "Email already exists.");
                    return Page();
                }

                // Hash the password and create a new user
                var hashedPassword = PasswordHelper.HashPassword(Input.Password);
                var newUser = new User 
                { 
                    Username = Input.Username, 
                    Email = Input.Email, 
                    PasswordHash = hashedPassword 
                };

                _context.Users.Add(newUser); // Add new user to the context
                _context.SaveChanges(); // Save changes to the database

                TempData["SuccessMessage"] = "Your account has been created successfully! You can now log in.";
                return RedirectToPage("/Index"); // Redirect to login page
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match.");
                return Page();
            }
        }

    }
}
