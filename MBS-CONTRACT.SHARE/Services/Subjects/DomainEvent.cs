using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Subjects;

public static class DomainEvent
{
    public record SubjectCreated(Guid IdEvent, string Name,int Status, Guid SemesterId) : IDomainEvent, ICommand;
}