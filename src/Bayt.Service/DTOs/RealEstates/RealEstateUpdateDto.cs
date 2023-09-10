using Bayt.Domain.Enums;

namespace Bayt.Service.DTOs.RealEstates;

public class RealEstateUpdateDto
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public int NumberOfRealEstates { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public int NumberOfRooms { get; set; }
    public decimal Cost { get; set; }
    public Currency Currency { get; set; }
    public long Area { get; set; }
    public UnitOfArea UnitOfArea { get; set; }
    public Guid AddressId { get; set; }
    public Guid UserId { get; set; }
}