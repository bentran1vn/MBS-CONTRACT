namespace MBS_CONTRACT.SHARE.Abstractions.Shared;

public interface IValidationResult
{
    public static readonly Error ValidationError = new("Validation Error", "A validation error occured");
    Error[] Errors { get; }
}
