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

            if (data == null)
                return new List<MakeDetailsDTO>();

            return data.Results.ToList();
        }
        public async Task<VehicleTypesAndModelsListsDTO> GetVehicleTypesAndModels(int makeId, int year)
        {
            var typesTask = GetVehicleTypes(makeId);
            var modelsTask = GetModels(makeId, year);

            await Task.WhenAll(typesTask, modelsTask);

            return new VehicleTypesAndModelsListsDTO
            {
                TypesResults = typesTask.Result,
                ModelsResults = modelsTask.Result
            };
        }


        public async Task<List<VehicleTypeDetailsDTO>> GetVehicleTypes(int makeId)
        {
            var url = $"GetVehicleTypesForMakeId/{makeId}?format=json";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<VehicleTypesDTO>(response);

            if (data == null)
                return new List<VehicleTypeDetailsDTO>();


            return data.Results.ToList();
        }

        public async Task<List<ModelDetailsDTO>> GetModels(int makeId, int year)
        {
            var url = $"GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<ModelDTO>(response);

            if (data == null)
                return new List<ModelDetailsDTO>();

            return data?.Results?.ToList() ?? new List<ModelDetailsDTO>();
        }

    }
}
