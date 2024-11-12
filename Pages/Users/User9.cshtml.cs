using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User9Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Find the square of the Complex number given!",
            "Express Z.",
            "Simplify it.",
            "Find Modulus",
            "Show it as Imaginary.",
            "Find Conjugate.",
            "Solve it and simplify it.",
            "Find x and y.",
            "Find relation between a and b.",
            "Find z."
        };
    }
}