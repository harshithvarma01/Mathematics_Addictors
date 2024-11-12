using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User1Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Students forms Committee.",
            "Arithmetic Progression.",
            "Addition of Probability.",
            "Conditional Probability.",
            "Independent Events.",
            "Proving of Events.",
            "Dice Rolls probability.",
            "Betting of Probability.",
            "Independent Probability.",
            "Boxes Probability."
        };
    }
}