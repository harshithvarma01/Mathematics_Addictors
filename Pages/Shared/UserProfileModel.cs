using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Trail2.Pages
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string OtherDetails { get; set; }

        [BindProperty]
        public string UserImage { get; set; } // Property to store the profile image URL

        public string EmailPattern => @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Add a regex for email validation

        public void OnGet()
        {
            // Initialize the model with user data
            UserName = "Your Name"; // Replace with actual logic to fetch user data
            Email = "user@example.com"; // Replace with actual logic to fetch user data
            OtherDetails = "Other user details..."; // Replace with actual logic
            UserImage = "https://th.bing.com/th/id/OIG1.1vSvbTvvqjPSaM3OoNHh?w=1024&h=1024&rs=1&pid=ImgDetMain"; // Default image URL
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Logic to handle form submission, including updating UserImage
                UserImage = Request.Form["ProfileImageUrl"]; // Get the image URL from the form

                // Here you can save changes to the database or user profile (implement accordingly)
                
                return RedirectToPage(); // Redirect to the same page to see changes
            }
            return Page();
        }
    }
}