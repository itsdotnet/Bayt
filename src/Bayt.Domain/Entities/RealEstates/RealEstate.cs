using Bayt.Domain.Commons;
using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Attachments;
using Bayt.Domain.Entities.Categories;
using Bayt.Domain.Entities.Users;
using Bayt.Domain.Enums;

namespace Bayt.Domain.Entities.RealEstates;

public class RealEstate : Auditable
{
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public int NumberOfRealEstates { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public int NumberOfRooms { get; set; }
    
    public decimal Cost { get; set; }
    public Currency Currency { get; set; }
    
    public long Area { get; set; }
    public UnitOfArea UnitOfArea { get; set; }

    public Guid AddressId { get; set; }
    public Address Address { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}