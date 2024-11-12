using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Trail2.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Trail2.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly DatabaseContext _context; // Database context for accessing user data

        public ProfileModel(DatabaseContext context)
        {
            _context = context; // Dependency injection of the database context
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string OtherDetails { get; set; }

        [BindProperty]
        public IFormFile ProfileImage { get; set; } // Property to hold the uploaded image

        public string UserImage { get; set; } = "https://example.com/default-profile.jpg"; // Default profile image URL

        public const string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Email pattern for validation

        public async Task OnGetAsync()
        {
            // Load user details from the database based on the logged-in user's ID
            var userId = HttpContext.Session.GetString("UserId"); // Assume user ID is stored in the session
            if (!string.IsNullOrEmpty(userId))
            {
                var user = await _context.Users.FindAsync(int.Parse(userId)); // Fetch the user from the database
                if (user != null)
                {
                    UserName = user.Username;
                    Email = user.Email;
                    OtherDetails = user.OtherDetails;
                    UserImage = user.UserImage ?? "https://example.com/default-profile.jpg"; // Default if UserImage is null
                }
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Save updated user details to the database
            var userId = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Login"); // Redirect to login if user ID is not found
            }

            var user = await _context.Users.FindAsync(int.Parse(userId)); // Find the user
            if (user == null)
            {
                return NotFound(); // Handle user not found
            }

            // Update user details
            user.Username = UserName;
            user.Email = Email;
            user.OtherDetails = OtherDetails;

            // Handle profile image URL update
            user.UserImage = Request.Form["ProfileImageUrl"]; // Get the image URL from the form

            // Handle image upload if a file is provided
            if (ProfileImage != null && ProfileImage.Length > 0)
            {
                var filePath = Path.Combine("wwwroot/images", ProfileImage.FileName); // Define the file path
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ProfileImage.CopyToAsync(stream); // Save the image to the server
                }
                user.UserImage = "/images/" + ProfileImage.FileName; // Update the user image URL
            }

            await _context.SaveChangesAsync(); // Save changes to the database

            return RedirectToPage(); // Redirect to refresh the page and show updated details
        }
    }
}
