using Bayt.Domain.Enums;
using Bayt.Service.DTOs.Addresses.Addresses;
using Bayt.Service.DTOs.Categories;
using Bayt.Service.DTOs.Users;

namespace Bayt.Service.DTOs.RealEstates;

public class RealEstateResultDto
{
    public CategoryResultDto Category { get; set; }
    public int NumberOfRealEstates { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public int NumberOfRooms { get; set; }
    public decimal Cost { get; set; }
    public Currency Currency { get; set; }
    public long Area { get; set; }
    public UnitOfArea UnitOfArea { get; set; }
    public AddressResultDto Address { get; set; }
    public UserResultDto User { get; set; }
}