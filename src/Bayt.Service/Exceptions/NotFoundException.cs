namespace Bayt.Service.Exceptions;

public class NotFoundException:Exception
{
    public int StatusCode { get; set; } = 404;

    public NotFoundException(string message):base(message)
    { }

    public NotFoundException(string message,Exception innerException):base(message,innerException)
    { }
}