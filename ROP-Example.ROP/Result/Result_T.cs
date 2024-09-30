using System.Collections.Immutable;

namespace ROP_Example.ROP.Result;

public readonly struct Result<T>
{
    public T Value { get; }
    public ImmutableArray<Error> Errors { get; } = ImmutableArray<Error>.Empty;

    public bool Success => Errors.IsEmpty;

    public Result(T value)
    {
        Value = value;
    }

    public Result(ImmutableArray<Error> errors)
    {
        Value = default;
        Errors = errors;
    }

}
