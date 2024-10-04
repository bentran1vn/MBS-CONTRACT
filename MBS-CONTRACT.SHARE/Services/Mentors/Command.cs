using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Mentors;

public class Command
{
    public record CreateMentorCommand(string Name, decimal Price, string Description) : ICommand;
}