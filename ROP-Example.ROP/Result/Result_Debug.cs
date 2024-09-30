namespace ROP_Example.ROP.Result;

public static partial class Result
{
    public static Result<bool> Debug(this Result<bool> r)
    {
        Console.WriteLine($"Result: {r.Value.GetType()} ({r.Value})");
        Console.WriteLine($"Errors: {r.Errors.Length}");
        for (int i = 0; i < r.Errors.Length; i++)
        {
            Console.WriteLine($"{i}. [{r.Errors[i].Code}] {r.Errors[i].Message}");
        }

        return r;
    }
}
