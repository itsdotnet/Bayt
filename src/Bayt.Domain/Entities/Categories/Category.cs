using Bayt.Domain.Commons;

namespace Bayt.Domain.Entities.Categories;

public class Category:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}