using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class User4Model : PageModel
{
    public List<string> Questions { get; private set; }

    public void OnGet()
    {
        Questions = new List<string>
        {
            "Differentiation by Power Rule.",
            "Differentiation by Product Rule.",
            "Differentiation by Quotient Rule.",
            "Differentiation by Chain Rule.",
            "Differentiation by Multiple Rule.",
            "Implicit Differentiation Rule.",
            "Logarithmic Differentiation Rule.",
            "Related Rates.",
            "Airplane Model.",
            "Exponential Model."
        };
    }
}