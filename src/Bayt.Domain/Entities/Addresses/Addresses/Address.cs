using Bayt.Domain.Commons;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;

namespace Bayt.Domain.Entities.Addresses.Addresses;

public class Address:Auditable
{
    public Guid CountryId { get; set; }
    public Country Country { get; set; }

    public Guid RegionId { get; set; }
    public Region Region { get; set; }

    public Guid DistrictId { get; set; }
    public District District { get; set; }
}