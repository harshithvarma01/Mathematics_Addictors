using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User3Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Integration Problem-1",
            "Integration Problem-2",
            "Integration Problem-3",
            "Integration Problem-4",
            "Integration Problem-5",
            "Integration Problem-6",
            "Integration Problem-7",
            "Integration Problem-8",
            "Integration Problem-9",
            "Integration Problem-10"
        };
    }
}