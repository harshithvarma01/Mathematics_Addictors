using System.Security.Cryptography;
using System.Text;

namespace Trail2.Helpers
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create(); // Create a SHA256 hash algorithm
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // Compute hash
            string hashedPassword = Convert.ToBase64String(bytes); // Return the hashed password as a base64 string

            // Debugging line to print hashed password for verification
            Console.WriteLine($"Hashed Password: {hashedPassword}");

            return hashedPassword;
        }
    }
}