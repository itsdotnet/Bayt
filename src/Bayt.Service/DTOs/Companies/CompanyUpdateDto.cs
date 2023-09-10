namespace Bayt.Service.DTOs.Companies;

public class CompanyUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}