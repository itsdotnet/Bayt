using Bayt.Domain.Commons;

namespace Bayt.Domain.Entities.Companies;

public class Company:Auditable
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}