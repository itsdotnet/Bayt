namespace Bayt.Service.DTOs.Addresses.Districts;

public class DistrictUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid RegionId { get; set; }
}