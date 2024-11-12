using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User10Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Find the angle?",
            "Prove it",
            "Prove it",
            "Find A and B",
            "Find the value of A.",
            "Show that",
            "Prove that.",
            "Use the identity to prove",
            "Prove that.",
            "Prove that using the identities."
        };
    }
}