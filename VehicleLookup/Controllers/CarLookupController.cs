using Microsoft.AspNetCore.Mvc;
using VehicleLookup.Services.Interfaces;

namespace VehicleLookup.Controllers
{
    public class CarLookupController : Controller
    {
        private readonly ICarLookup _carLookup;
        public CarLookupController(ICarLookup carLookup)
        {
            _carLookup = carLookup;
        }

        public async Task<ActionResult> Index()
        {
            var makes = await _carLookup.GetAllMakes();
            ViewBag.Makes = makes;
            return View();
        }
    }
}
