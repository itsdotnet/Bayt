using Bayt.Domain.Commons;
using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Users;
using Bayt.Domain.Enums;

namespace Bayt.Domain.Entities.Roommates;

public class Roommate : Auditable
{
    public string Description { get; set; }
    public Whom Whom { get; set; }
    
    public decimal Rent { get; set; }
    public Currency Currency { get; set; }

    public Guid AddressId { get; set; }
    public Address Address { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}