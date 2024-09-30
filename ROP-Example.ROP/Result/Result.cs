namespace ROP_Example.ROP.Result;

public static partial class Result
{
    public static Result<T> Success<T>(this T value) => new(value);

}
