using MBS_CONTRACT.SHARE.Abstractions.Shared;
using MediatR;

namespace MBS_CONTRACT.SHARE.Abstractions.Messages;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
