namespace MBS_CONTRACT.SHARE.Abstractions.Shared;

public class ValidationResult<TValue> : Result<TValue>, IValidationResult
{
    protected internal ValidationResult(Error[] errors) : base(default, false, IValidationResult.ValidationError)
    {
        Errors = errors;
    }

    public Error[] Errors { get; }

    public static ValidationResult<TValue> WithErrors(Error[] errors) => new (errors);
}