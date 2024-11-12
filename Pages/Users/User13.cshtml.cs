using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User13Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Unitary Matrix?",
            "Nullity.",
            "Solve it.",
            "Show that",
            "Eigen Values?",
            "Linearly Dependent or Linearly Independent?",
            "Verify Linearly Independent.",
            "Show it is Diagonizable",
            "Is it Linear Transformation?",
            "Find Matrix Representation",

        };
    }
}