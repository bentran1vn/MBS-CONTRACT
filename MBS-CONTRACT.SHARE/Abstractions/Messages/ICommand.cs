using MassTransit;
using MBS_CONTRACT.SHARE.Abstractions.Shared;
using MediatR;

namespace MBS_CONTRACT.SHARE.Abstractions.Messages;

[ExcludeFromTopology]
public interface ICommand : IRequest<Result>
{
}

[ExcludeFromTopology]
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
