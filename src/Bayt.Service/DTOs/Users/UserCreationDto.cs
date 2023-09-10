using System.ComponentModel.DataAnnotations;
using Bayt.Domain.Enums;

namespace Bayt.Service.DTOs.Users;

public class UserCreationDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Role Role { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}