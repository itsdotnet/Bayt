using Bayt.Domain.Commons;
using Bayt.Domain.Enums;

namespace Bayt.Domain.Entities.Roommates;

public class Roommate:Auditable
{
    public string Description { get; set; }
    public Whom Whom { get; set; }
    public decimal Rent { get; set; }
    public Currency Currency { get; set; }
    
}