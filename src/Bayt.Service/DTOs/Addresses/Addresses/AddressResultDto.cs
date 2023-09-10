using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Service.DTOs.Addresses.Countries;
using Bayt.Service.DTOs.Addresses.Districts;
using Bayt.Service.DTOs.Addresses.Regions;

namespace Bayt.Service.DTOs.Addresses.Addresses;

public class AddressResultDto
{
    public Guid Id { get; set; }
    public CountryResultDto Country { get; set; }
    public RegionResultDto Region { get; set; }
    public DistrictResultDto District { get; set; }
}