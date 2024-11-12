using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User8Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Find Domain and Range.",
            "Sigmus Function",
            "Cartesian Product.",
            "Express the Relation for the Function.",
            "Find Range,Domin and co-domain",
            "Find the related function.",
            "Redefine the Function.",
            "Draw the Graph for the given Function.",
            "Find domain and range.",
            "Find the Real Range for the function.",
        };
    }
}