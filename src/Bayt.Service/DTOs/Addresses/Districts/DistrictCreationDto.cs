namespace Bayt.Service.DTOs.Addresses.Districts;

public class DistrictCreationDto
{
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid RegionId { get; set; }
}