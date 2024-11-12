using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User11Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Find the principle value",
            "Find the value",
            "Find the value.",
            "Prove it",
            "Find the value.",
            "Find the Value.",
            "Evaluate it.",
            "Prove it",
            "Prove that.",
            "Solve it."
        };
    }
}