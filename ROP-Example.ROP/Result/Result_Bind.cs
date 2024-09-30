namespace ROP_Example.ROP.Result;

public static partial class Result
{
    public static Result<U> Bind<T, U>(this Result<T> r, Func<T, Result<U>> func)
    {
        return r.Success
            ? func.Invoke(r.Value)
            : Result.Failure<U>(r.Errors);
    }
}
