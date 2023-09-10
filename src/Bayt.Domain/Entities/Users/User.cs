using System.ComponentModel.DataAnnotations;
using Bayt.Domain.Commons;
using Bayt.Domain.Enums;

namespace Bayt.Domain.Entities.Users;

public class User:Auditable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Role Role { get; set; }
    
    [Required]
    public string PhoneNumber { get; set; }
    
    [Required][MinLength(8)]
    public string Password { get; set; }
}