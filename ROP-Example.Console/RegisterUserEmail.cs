using ROP_Example.ROP.Result;

namespace ROP_Example.Console;

public class RegisterUserEmail
{
    readonly List<string> _emails = new();
    public IReadOnlyList<string> Emails => _emails;


    public Result<bool> RegisterEmail(string email)
    {
        return ValidateEmail(email)
            .Bind(AddEmail)
            .Debug();
    }

    Result<string> ValidateEmail(string email)
    {
        List<string> errors = new();

        if (!email.Contains('@'))
            errors.Add("Not valid email");

        if (!email.Contains(".com"))
            errors.Add("Not valid email");

        return errors.Count != 0
            ? Result.Failure<string>(errors)
            : Result.Success(email);
    }

    Result<bool> AddEmail(string email)
    {
        if (_emails.Contains(email))
            return Result.Failure<bool>("Already registered");

        _emails.Add(email);

        return Result.Success(true);
    }

}
