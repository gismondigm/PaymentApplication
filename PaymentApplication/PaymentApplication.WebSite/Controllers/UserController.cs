using Microsoft.AspNetCore.Mvc;
using PaymentApplication.WebSite.Models;

namespace PaymentApplication.WebSite.Controllers
{
    [Route("A")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserPayment userPayment)
        {
            var test = userPayment.Name;
            return Redirect("/");
        }
    }
}
