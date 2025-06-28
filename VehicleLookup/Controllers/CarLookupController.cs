using Microsoft.AspNetCore.Mvc;
using VehicleLookup.DTOs;
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

        [HttpPost]
        public async Task<ActionResult> GetVehicleResults(string makeId, int year)
        {
            var result = await _carLookup.GetVehicleTypesAndModels(int.Parse(makeId), year);
            return View("VehicleLookupResult", result);
        }
    }
}
