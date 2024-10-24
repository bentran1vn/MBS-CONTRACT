using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Users;

public static class DomainEvent
{
    public record MentorCreated(Guid IdEvent, Guid Id): IDomainEvent, ICommand;
    public record MentorSlotCreated(Guid IdEvent, IEnumerable<Slot> Slots) : IDomainEvent, ICommand;

    public class Slot
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public Guid? MentorId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date { get; set; }
        public bool IsOnline { get; set; }
        public string? Note { get; set; }
        public short? Month { get; set; }
        public bool IsBook { get; set; }
    }
}