using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Users;

public static class Command
{
    public record CreateMentor(Guid MentorId) : ICommand;
}
