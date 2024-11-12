using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User5Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Find Conditions.",
            "Find How many Solutions.",
            "Echelon Form Problem.",
            "GaussJordan Problem.",
            "Rank by echelon Form.",
            "System of equations.",
            "Find a,b.",
            "Find Lambda?",
            "Find Inverse of Matrix.",
            "Find Normal Form."
        };
    }
}