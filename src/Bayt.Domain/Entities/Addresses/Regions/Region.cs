using Bayt.Domain.Commons;
using Bayt.Domain.Entities.Addresses.Countries;

namespace Bayt.Domain.Entities.Addresses.Regions;

public class Region:Auditable
{
    public string Name { get; set; }

    public Guid CountryId { get; set; }
    public Country Country { get; set; }
}