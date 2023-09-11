namespace Bayt.Api.Models;

#pragma warning disable

public class Responce
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
}