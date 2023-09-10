using Microsoft.AspNetCore.Http;

namespace Bayt.Service.DTOs.Attachments;

public class AttachmentCreationDto
{
    public IFormFile File { get; set; }
}