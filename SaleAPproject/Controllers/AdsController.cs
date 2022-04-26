using Microsoft.AspNetCore.Mvc;

namespace SaleAPproject.Controllers
{
    public class AdsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
