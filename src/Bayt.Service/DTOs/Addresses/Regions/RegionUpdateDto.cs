namespace Bayt.Service.DTOs.Addresses.Regions;

public class RegionUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
}