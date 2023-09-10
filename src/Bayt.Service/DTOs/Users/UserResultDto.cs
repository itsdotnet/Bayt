using Bayt.Domain.Enums;

namespace Bayt.Service.DTOs.Users;

public class UserResultDto
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Role Role { get; set; }
    public string PhoneNumber { get; set; }
}