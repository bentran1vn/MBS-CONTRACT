using MBS_CONTRACT.SHARE.Abstractions.Shared;
using MediatR;

namespace MBS_CONTRACT.SHARE.Abstractions.Messages;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
