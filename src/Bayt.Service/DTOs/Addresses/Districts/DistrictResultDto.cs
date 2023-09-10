using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Service.DTOs.Addresses.Countries;
using Bayt.Service.DTOs.Addresses.Regions;

namespace Bayt.Service.DTOs.Addresses.Districts;

public class DistrictResultDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CountryResultDto Country { get; set; }
    public RegionResultDto Region { get; set; }
}