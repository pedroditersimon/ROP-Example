using System.Collections.Immutable;

namespace ROP_Example.ROP.Result;

public static partial class Result
{
    public static Result<T> Failure<T>(ImmutableArray<Error> errors) => new(errors);

    public static Result<T> Failure<T>(int code, string msg) => Failure<T>(ImmutableArray.Create(new Error(code, msg)));
    public static Result<T> Failure<T>(string msg) => Failure<T>(0, msg);

    public static Result<T> Failure<T>(List<string> errors) => Failure<T>(errors.Select(msg => new Error(0, msg)).ToImmutableArray());
}
