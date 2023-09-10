namespace Bayt.Service.DTOs.Addresses.Addresses;

public class AddressCreationDto
{
    public Guid CountryId { get; set; }
    public Guid RegionId { get; set; }
    public Guid DistrictId { get; set; }
}