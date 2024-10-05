using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Mentors;

public class DomainEvent
{
    public record MentorCreated(Guid IdEvent, Guid Id, string Email,
        string FullName, int Role, int Points, int Status,
        DateTimeOffset CreatedOnUtc, bool IsDeleted) : IDomainEvent, ICommand;
}