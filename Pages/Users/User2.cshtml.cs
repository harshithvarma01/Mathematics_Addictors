using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User2Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Greater Percentage.",
            "Survey Problem.",
            "Student Weights.",
            "Manufactured parts.",
            "Correaltion study.",
            "Cumulative frequency polygon.",
            "Rainfall Problem.",
            "Convex polygon.",
            "Interior Angle.",
            "Regular Nanogon."
        };
    }
}