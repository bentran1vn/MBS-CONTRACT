using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Groups;

public static class DomainEvents
{
    public record GroupCreated(Guid IdEvent, Guid Id, string Name, Guid? MentorId, string Stacks) : IDomainEvent, ICommand;
}
