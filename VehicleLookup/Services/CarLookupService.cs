using Newtonsoft.Json;
using VehicleLookup.DTOs;
using VehicleLookup.Services.Interfaces;

namespace VehicleLookup.Services
{
    public class CarLookupService : ICarLookup
    {
        private readonly HttpClient _httpClient;

        public CarLookupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://vpic.nhtsa.dot.gov/api/vehicles/");
        }

        public async Task<List<MakeDetailsDTO>> GetAllMakes()
        {
            var response = await _httpClient.GetStringAsync("getallmakes?format=json");
            var data = JsonConvert.DeserializeObject<MakeDTO>(response);

            return data.Results.ToList();
        }


    }
}
