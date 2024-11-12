using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class QuestionDetailModel : PageModel
{
    public string QuestionImagePath { get; private set; }
    public string ImagePath { get; set; }

    public void OnGet(int boxId, int questionId)
    {
        // Set the path for the question image based on box ID and question ID
        QuestionImagePath = $"/images/box{boxId}/question{questionId + 1}.png"; // Adjust path for each box

        // Check if the uploaded answer image exists
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", $"answer_{boxId}_{questionId}.jpg");
        if (System.IO.File.Exists(fullPath))
        {
            ImagePath = $"/images/box{boxId}/answer_{boxId}_{questionId}.jpg"; // Update ImagePath if the uploaded answer image exists
        }
        else
        {
            ImagePath = null; // Clear path if file does not exist
        }
    }

    public async Task<IActionResult> OnPostAsync(IFormFile answerImage, int boxId, int questionId)
    {
        if (answerImage != null && answerImage.Length > 0)
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", $"box{boxId}");
            Directory.CreateDirectory(directoryPath); // Ensure the directory exists

            string filePath = Path.Combine(directoryPath, $"answer_{boxId}_{questionId}.jpg"); // Save answer images as answer_boxId_questionId.jpg

            // Save the file
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await answerImage.CopyToAsync(fileStream);
            }

            // Update the ImagePath for rendering
            ImagePath = $"/images/box{boxId}/answer_{boxId}_{questionId}.jpg";
        }

        return Page(); // Return to the same page after submission
    }

    public IActionResult OnPostDelete(int boxId, int questionId)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", $"box{boxId}", $"answer_{boxId}_{questionId}.jpg");

        if (System.IO.File.Exists(filePath))
        {
            System.IO.File.Delete(filePath); // Delete the answer image file
        }

        // Clear ImagePath to ensure the UI updates
        ImagePath = null;

        return RedirectToPage(new { boxId = boxId, questionId = questionId }); // Redirect to reload the page state
    }
}
