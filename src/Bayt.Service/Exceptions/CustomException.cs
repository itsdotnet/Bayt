namespace Bayt.Service.Exceptions;

public class CustomException:Exception
{
    public int StatusCode { get; set; }
    
    public CustomException(string message,int statuscode):base(message)
    {
        StatusCode = statuscode;
    }
}