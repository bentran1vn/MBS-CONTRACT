using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Users;

public static class DomainEvent
{
    public record MentorCreated(Guid IdEvent, Guid Id): IDomainEvent, ICommand;
    public record SlotsCreated(Guid IdEvent, IEnumerable<Slot> Slots, Guid MentorId) : IDomainEvent, ICommand;

    public class Slot
    {
        public Guid? MentorId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date { get; set; }
        public bool IsOnline { get; set; }
        public string? Note { get; set; }
        public short? Month { get; set; }
        public bool IsBook { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}