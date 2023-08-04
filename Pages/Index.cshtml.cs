using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace calculatorAppAA.Pages
{
    public class IndexModel : PageModel

    {

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }

        [BindProperty]
        public string Operator { get; set; }

        public int Result { get; private set; }

        public void OnGet()
        {
            // Initialize any necessary data on page load (if needed)
        }

        public void OnPost()
        {
            // Perform the calculation based on the selected operator
            switch (Operator)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 != 0)
                        Result = Number1 / Number2;
                    else
                        Result = 0; // Handle division by zero
                    break;
                default:
                    Result = 0; // Invalid operator
                    break;
            }
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
 
    }
}