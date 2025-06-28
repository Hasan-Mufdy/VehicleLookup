namespace VehicleLookup.DTOs
{
    public class VehicleTypesAndModelsListsDTO
    {
        public List<VehicleTypeDetailsDTO> TypesResults { get; set; } = new List<VehicleTypeDetailsDTO>();
        public List<ModelDetailsDTO> ModelsResults { get; set; } = new List<ModelDetailsDTO>();

    }
}
