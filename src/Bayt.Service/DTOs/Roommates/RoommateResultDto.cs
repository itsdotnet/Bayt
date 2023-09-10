using Bayt.Domain.Enums;
using Bayt.Service.DTOs.Addresses.Addresses;
using Bayt.Service.DTOs.Users;

namespace Bayt.Service.DTOs.Roommates;

public class RoommateResultDto
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public Whom Whom { get; set; }
    public decimal Rent { get; set; }
    public Currency Currency { get; set; }
    public AddressResultDto Address { get; set; }
    public UserResultDto User { get; set; }
}