namespace IgnitisHomework.DTOs
{
    public class PowerPlantsWrapperDto
    {
        public List<PowerPlantDto> PowerPlants { get; set; } = new List<PowerPlantDto>();
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}