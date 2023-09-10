using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Service.DTOs.Addresses.Countries;

namespace Bayt.Service.DTOs.Addresses.Regions;

public class RegionResultDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CountryResultDto Country { get; set; }
}