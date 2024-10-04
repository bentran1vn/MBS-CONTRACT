using MBS_CONTRACT.SHARE.Abstractions.Shared;
using MediatR;

namespace MBS_CONTRACT.SHARE.Abstractions.Messages;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
