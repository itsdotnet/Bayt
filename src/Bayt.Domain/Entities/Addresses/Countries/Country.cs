using Bayt.Domain.Commons;

namespace Bayt.Domain.Entities.Addresses.Countries;

public class Country:Auditable
{
    public string Name { get; set; }
    public string Code { get; set; }
}