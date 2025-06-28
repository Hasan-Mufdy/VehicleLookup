using VehicleLookup.DTOs;

namespace VehicleLookup.Services.Interfaces
{
    public interface ICarLookup
    {
        Task<List<MakeDetailsDTO>> GetAllMakes();
    }
}
