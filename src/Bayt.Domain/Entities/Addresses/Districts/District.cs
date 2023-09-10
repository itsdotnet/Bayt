using Bayt.Domain.Commons;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Regions;

namespace Bayt.Domain.Entities.Addresses.Districts;

public class District:Auditable
{
    public string Name { get; set; }

    public Guid CountryId { get; set; }
    public Country Country { get; set; }

    public Guid RegionId { get; set; }
    public Region Region { get; set; }
}