using Bayt.Domain.Enums;

namespace Bayt.Service.DTOs.Roommates;

public class RoommateCreationDto
{
    public string Description { get; set; }
    public Whom Whom { get; set; }
    public decimal Rent { get; set; }
    public Currency Currency { get; set; }
    public Guid AddressId { get; set; }
    public Guid UserId { get; set; }
}