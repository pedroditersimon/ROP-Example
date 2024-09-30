namespace ROP_Example.ROP;

public class Error
{
    public int Code { get; }
    public string Message { get; }

    public Error(int code, string msg)
    {
        Code = code;
        Message = msg;
    }
}
