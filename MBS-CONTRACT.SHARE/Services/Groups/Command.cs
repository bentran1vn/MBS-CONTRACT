using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Groups;

public static class Command
{
    public record CreateGroupCommand(string Name,Guid MentorId,string Stacks) : ICommand;
}
