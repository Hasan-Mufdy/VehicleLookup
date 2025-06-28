namespace VehicleLookup.DTOs
{
    public class MakeDTO
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public List<MakeDetailsDTO> Results { get; set; } = new List<MakeDetailsDTO>();
    }
}
