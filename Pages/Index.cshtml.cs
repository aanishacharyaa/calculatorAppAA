using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalculatorLibrary;

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
            CalculatorClass calculator = new CalculatorClass();

            switch (Operator)
            {
                case "+":
                    Result = calculator.Add(Number1, Number2);
                    break;
                case "-":
                    Result = calculator.Subtract(Number1, Number2);
                    break;
                case "*":
                    Result = calculator.Multiply(Number1, Number2);
                    break;
                case "/":
                    if (Number2 != 0)
                        Result = calculator.Divide(Number1, Number2);
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