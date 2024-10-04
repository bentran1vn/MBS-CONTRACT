using MassTransit;

namespace MBS_CONTRACT.SHARE.Abstractions.Messages;

[ExcludeFromTopology]
public interface IDomainEvent
{
    public Guid IdEvent { get; init; }
}