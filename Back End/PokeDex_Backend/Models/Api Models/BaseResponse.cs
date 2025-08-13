namespace PokeDex_Backend.Models.Api_Models;

public class BaseResponse<T>
{
    public BaseResponse()
    {
    }

    public BaseResponse(T data, bool success, string message)
    {
        
    }
    
    public T Data { get; private set; }
    public bool Success { get; private set; }
    public string Message { get; private set; }
}