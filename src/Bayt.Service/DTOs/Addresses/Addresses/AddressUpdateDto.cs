namespace Bayt.Service.DTOs.Addresses.Addresses;

public class AddressUpdateDto
{
    public Guid Id { get; set; }
    public Guid CountryId { get; set; }
    public Guid RegionId { get; set; }
    public Guid DistrictId { get; set; }
}