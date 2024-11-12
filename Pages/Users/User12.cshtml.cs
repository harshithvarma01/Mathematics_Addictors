using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User12Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Trailing Zeroes.",
            "Prime?",
            "Prime Factorisation",
            "Non zero multiples.",
            "Value?",
            "Common Factors.",
            "Common Multiples.",
            "Sequencing..",
            "Sum and Difference between Primes.",
            "Divisibility Rule."
        };
    }
}