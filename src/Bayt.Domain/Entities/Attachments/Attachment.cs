using Bayt.Domain.Commons;

namespace Bayt.Domain.Entities.Attachments;

public class Attachment : Auditable
{
    public string FileName { get; set; }
    public string FilePath { get; set; }
}