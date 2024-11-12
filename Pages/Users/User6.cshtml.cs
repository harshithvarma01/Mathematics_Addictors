using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User6Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Rolle's Theorem",
            "Lagrange's Mean Value Theorem.",
            "Rectangular Paralleleopiped.",
            "Stationary Points",
            "Explain Rolles Theorem.",
            "Explain Cauchy's Theorem.",
            "Double Integral Calculas.",
            "Change order of Integration",
            "Ellipse problem.",
            "Cartesian form"
        };
    }
}