using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentApplication.WebSite.Models;
using PaymentApplication.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PaymentApplication.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }


        public string firstName { get; set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<UserPayment> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
        public IActionResult OnPost()
        {

            Console.WriteLine(Name);

            Console.WriteLine(Email);

            Console.WriteLine(Subject);

            Console.WriteLine(Message);

            return Page();
        }
    }
}
