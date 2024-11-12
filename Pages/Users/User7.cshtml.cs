using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User7Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Roster Form",
            "Sets into a Roster Form",
            "Odd numbers",
            "Express the following Sets.",
            "Express the sets.",
            "Prove the sets",
            "Solve the conditions.",
            "Sports Problem.",
            "Find the Condition.",
            "Survey Problem.",
        };
    }
}