namespace Bayt.Service.Exceptions;

public class AlreadyExistsException:Exception
{
    public int StatusCode { get; set; } = 403;

    public AlreadyExistsException(string message):base(message)
    { }

    public AlreadyExistsException(string message,Exception innerException):base(message,innerException)
    { }
}