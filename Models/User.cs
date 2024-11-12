using System.ComponentModel.DataAnnotations;

namespace Trail2.Models
{
    public class User
    {
        public int Id { get; set; } // Primary key

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        public string Username { get; set; } // User's display name

        [Required(ErrorMessage = "Password is required.")]
        public string PasswordHash { get; set; } // To store hashed passwords securely

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } // User's email

        public string? OtherDetails { get; set; } // Allowing OtherDetails to be nullable

        // Default profile image URL
        public string UserImage { get; set; } = "https://example.com/default-profile.jpg"; 
    }
}