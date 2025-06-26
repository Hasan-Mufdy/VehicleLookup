using Microsoft.AspNetCore.Mvc;

namespace VehicleLookup.Controllers
{
    public class CarLookupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
