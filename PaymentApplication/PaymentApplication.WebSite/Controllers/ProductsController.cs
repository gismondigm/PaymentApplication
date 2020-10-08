using System.Collections.Generic;
using PaymentApplication.WebSite.Models;
using PaymentApplication.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace PaymentApplication.WebSite.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("Index")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<UserPayment> Get()
        {
            return ProductService.GetProducts();
        }

        [HttpPatch]
        public ActionResult Patch([FromBody] RatingRequest request)
        {
            //ProductService.AddRating(request.ProductId, request.Rating);

            return Ok();
        }

        [HttpPost]
        public IActionResult AddUser(UserPayment userPayment)
        {
            var test = userPayment.Name;
            //ProductService.SubmitName(userPayment.Name);
            return Redirect("/");
        }

        public class RatingRequest
        {
            public string ProductId { get; set; }
            public int Rating { get; set; }
        }
    }
}